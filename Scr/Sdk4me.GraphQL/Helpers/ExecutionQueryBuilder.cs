using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The 4me execution query builder.
    /// </summary>
    internal sealed class ExecutionQueryBuilder
    {
        /// <summary>
        /// Create an execution query object.
        /// </summary>
        /// <param name="query">The GraphQL query.</param>
        /// <param name="defaultItemsPerRequest">The default items per request value.</param>
        /// <returns>An <see cref="ExecutionQuery"/> based on the IQuery.</returns>
        /// <exception cref="Sdk4meInvalidFieldNameException"></exception>
        internal static ExecutionQuery BuildQuery(IQuery query, int defaultItemsPerRequest)
        {
            if (string.IsNullOrEmpty(query.FieldName))
                throw new Sdk4meInvalidFieldNameException($"{nameof(query)} first field is not a root query field.");

            return BuildQuery(query, 0, defaultItemsPerRequest);
        }

        /// <summary>
        /// Get the GraphQL mutation query.
        /// </summary>
        /// <typeparam name="TOutEntity">Any type implementing <see cref="Payload"/>.</typeparam>
        /// <typeparam name="TInEntity">Any type implementing <see cref="PropertyChangeSet"/>.</typeparam>
        /// <param name="input">The input data.</param>
        /// <returns>A GraphQL mutation based on the <see cref="IQuery"/>.</returns>
        /// <exception cref="Sdk4meInvalidFieldNameException"></exception>
        internal static string GetGraphQLQuery<TOutEntity, TInEntity>(Mutation<TOutEntity, TInEntity> input)
            where TOutEntity : Payload
            where TInEntity : PropertyChangeSet
        {
            ExecutionQuery query;
            if (typeof(Payload).IsAssignableFrom(typeof(TOutEntity)))
            {
                query = new(string.Empty, typeof(TOutEntity))
                {
                    IsConnection = false,
                    Fields = GetExecutionQueryFields(typeof(Payload), null)
                };

                foreach (IQuery q in input.Queries)
                    query.Queries.Add(BuildQuery(q, 0, 1));
            }
            else
            {
                query = new(string.Empty, typeof(TOutEntity))
                {
                    IsConnection = false,
                    Fields = GetExecutionQueryFields(typeof(TOutEntity), null)
                };
            }

            return $"mutation($input: {input.DataTypeName}) {{{input.FieldName}(input: $input) {GetGraphQLQuery(BuildQuery(query))}}}";
        }

        /// <summary>
        /// Get the GraphQL query.
        /// </summary>
        /// <param name="executionQuery">The execution query object.</param>
        /// <returns>A GraphQL query based on the <see cref="ExecutionQuery"/>.</returns>
        internal static string GetGraphQLQuery(ExecutionQuery executionQuery)
        {
            StringBuilder builder = new();

            if (!string.IsNullOrEmpty(executionQuery.FilterByID))
            {
                builder.Append($"node(id: {SerializeObject(executionQuery.FilterByID)}) {{... on {executionQuery.DataType.Name} {{");

                string fields = string.Join(" ", executionQuery.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                builder.Append(fields);
                builder.Append(fields != string.Empty && executionQuery.Queries.Count > 0 ? " " : "");

                HashSet<string> subQueries = new();
                foreach (ExecutionQuery query in executionQuery.Queries)
                    subQueries.Add(GetGraphQLQuery(query));
                subQueries.RemoveWhere(x => string.IsNullOrWhiteSpace(x));
                builder.Append(string.Join(" ", subQueries));

                builder.Append("}}");
            }
            else if (executionQuery.IsConnection)
            {
                builder.Append(executionQuery.FieldName);
                builder.Append('(');
                builder.Append($"first:{executionQuery.ItemsPerRequest}");

                if (executionQuery.Depth.Equals(0))
                {
                    if (executionQuery.Filters.Count > 0 || executionQuery.CustomFilters.Count > 0 || executionQuery.QueryFilter != string.Empty)
                    {
                        builder.Append($" filter:{{");

                        if (executionQuery.Filters.Count > 0)
                        {
                            builder.Append(string.Join(" ", executionQuery.Filters));
                        }

                        if (executionQuery.CustomFilters.Count > 0)
                        {
                            if (executionQuery.Filters.Count > 0)
                                builder.Append(' ');
                            builder.Append("customFilters:[");
                            builder.Append(string.Join(" ", executionQuery.CustomFilters));
                            builder.Append(']');
                        }

                        if (executionQuery.QueryFilter != string.Empty)
                        {
                            if (executionQuery.Filters.Count > 0 || executionQuery.CustomFilters.Count > 0)
                                builder.Append(' ');
                            builder.Append(executionQuery.QueryFilter);
                        }

                        builder.Append('}');
                    }

                    if (executionQuery.View != string.Empty)
                        builder.Append($" view:{executionQuery.View}");

                    if (executionQuery.OrderByField != string.Empty)
                    {
                        if (executionQuery.OrderByOrder != string.Empty)
                            builder.Append($" order:{{field:{executionQuery.OrderByField} direction:{executionQuery.OrderByOrder}}}");
                        else
                            builder.Append($" order:{{field:{executionQuery.OrderByField}}}");
                    }
                }

                if (executionQuery.EndCursor != string.Empty)
                    builder.Append($" after:\"{executionQuery.EndCursor}\"");
                builder.Append(')');

                builder.Append("{nodes{");
                if (executionQuery.OnlyQueryIdentifier)
                {
                    if (!executionQuery.HasIdentifier)
                        throw new Sdk4meException($"Pagination not possible, {executionQuery.FieldName} has no identifier.");
                    builder.Append("id ");
                }
                else
                {
                    string fields = string.Join(" ", executionQuery.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                    builder.Append(fields);
                    builder.Append(fields != string.Empty && executionQuery.Queries.Count > 0 ? " " : "");
                }

                HashSet<string> subQueries = new();
                foreach (ExecutionQuery query in executionQuery.Queries)
                    subQueries.Add(GetGraphQLQuery(query));
                subQueries.RemoveWhere(x => string.IsNullOrWhiteSpace(x));
                builder.Append(string.Join(" ", subQueries));

                builder.Append("} pageInfo{endCursor hasNextPage}}");
            }
            else
            {
                if (executionQuery.Queries.Count > 0 || executionQuery.Fields.Any(x => x.IsSelected))
                {
                    builder.Append(executionQuery.FieldName);
                    builder.Append('{');

                    if (executionQuery.OnTypeQueries.Count > 0)
                    {
                        builder.Append("__typename");
                        foreach (KeyValuePair<string, ExecutionQuery> onTypeQuery in executionQuery.OnTypeQueries)
                        {
                            builder.Append($" ... on {onTypeQuery.Key} {{");
                            string fields = string.Join(" ", onTypeQuery.Value.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                            builder.Append(fields);
                            builder.Append(fields != string.Empty && onTypeQuery.Value.Queries.Count > 0 ? " " : "");

                            HashSet<string> subQueries = new();
                            foreach (ExecutionQuery query in onTypeQuery.Value.Queries)
                                subQueries.Add(GetGraphQLQuery(query));
                            subQueries.RemoveWhere(x => string.IsNullOrWhiteSpace(x));
                            builder.Append(string.Join(" ", subQueries));
                            builder.Append('}');
                        }
                    }
                    else
                    {
                        string fields = string.Join(" ", executionQuery.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                        builder.Append(fields);
                        builder.Append(fields != string.Empty && executionQuery.Queries.Count > 0 ? " " : "");

                        HashSet<string> subQueries = new();
                        foreach (ExecutionQuery query in executionQuery.Queries)
                            subQueries.Add(GetGraphQLQuery(query));
                        subQueries.RemoveWhere(x => string.IsNullOrWhiteSpace(x));
                        builder.Append(string.Join(" ", subQueries));
                    }
                    builder.Append('}');
                }
            }

            return builder.ToString();
        }

        /// <summary>
        /// Build the GraphQL query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="depth">The current connection depth.</param>
        /// <param name="defaultItemsPerRequest">The default items per request.</param>
        /// <returns>An <see cref="ExecutionQuery"/> based on the <see cref="IQuery"/>.</returns>
        private static ExecutionQuery BuildQuery(IQuery query, int depth, int defaultItemsPerRequest)
        {
            ExecutionQuery retval = new(query.FieldName, query.DataType)
            {
                View = query.SelectedView,
                OrderByField = query.SelectedOrderByField,
                OrderByOrder = query.SelectedOrderByOrder,
                ItemsPerRequest = query.SelectedItemsPerRequest ?? defaultItemsPerRequest,
                Filters = query.Filters.ToHashSet(),
                QueryFilter = query.QueryFilter,
                FilterByID = query.FilterByID,
                CustomFilters = query.CustomFilters.ToHashSet(),
                Fields = GetExecutionQueryFields(query.DataType, query.SelectedFields),
                IsConnection = query.IsConnection,
                Depth = depth
            };

            foreach (KeyValuePair<string, IQuery> item in query.OnTypesQueries)
                retval.OnTypeQueries.Add(item.Key, BuildQuery(item.Value, depth + 1, defaultItemsPerRequest));

            foreach (IQuery subQuery in query.Queries)
                retval.Queries.Add(BuildQuery(subQuery, depth + 1, defaultItemsPerRequest));

            BuildQuery(retval);
            return retval;
        }

        /// <summary>
        /// Convert all non-primary field and connections into an <see cref="ExecutionQuery"/>.
        /// </summary>
        /// <param name="query">An <see cref="ExecutionQuery"/>.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private static ExecutionQuery BuildQuery(ExecutionQuery query)
        {
            foreach (ExecutionQueryField field in query.Fields)
            {
                if (field.IsSelected)
                {
                    if (field.IsConnection)
                    {
                        if (query.Queries.FirstOrDefault(x => x.FieldName.Equals(field.Name)) is null)
                        {
                            Type type = field.PropertyInfo.PropertyType.GetGenericArguments()[0];
                            ExecutionQuery subQuery = new(field.Name, type)
                            {
                                Fields = GetExecutionQueryFields(type, null),
                                Depth = query.Depth + 1,
                                IsConnection = true
                            };
                            query.Queries.Add(BuildQuery(subQuery));
                        }
                        field.IsSelected = false;
                    }
                    else if (field.IsObject)
                    {
                        if (query.Queries.FirstOrDefault(x => x.FieldName.Equals(field.Name)) is null)
                        {
                            ExecutionQuery subQuery = new(field.Name, field.PropertyInfo.PropertyType)
                            {
                                Fields = GetExecutionQueryFields(field.PropertyInfo.PropertyType, null),
                                Depth = query.Depth + 1
                            };
                            query.Queries.Add(BuildQuery(subQuery));
                        }
                        field.IsSelected = false;
                    }
                    else if (field.IsList)
                    {
                        if (query.Queries.FirstOrDefault(x => x.FieldName.Equals(field.Name)) is null)
                        {
                            Type type = field.PropertyInfo.PropertyType.GetGenericArguments()[0];
                            ExecutionQuery subQuery = new(field.Name, type)
                            {
                                Fields = GetExecutionQueryFields(type, null),
                                Depth = query.Depth + 1
                            };
                            query.Queries.Add(BuildQuery(subQuery));
                        }
                        field.IsSelected = false;
                    }
                    else if (field.IsCustomFields)
                    {
                        if (field.PropertyInfo.PropertyType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.PropertyType == typeof(CustomField)).FirstOrDefault() is PropertyInfo customFieldProperty)
                        {
                            ExecutionQuery subQuery = new(field.Name, customFieldProperty.PropertyType)
                            {
                                Fields = GetExecutionQueryFields(customFieldProperty.PropertyType, null),
                                Depth = query.Depth + 1
                            };
                            query.Queries.Add(BuildQuery(subQuery));
                        }
                        else
                        {
                            throw new ApplicationException($"{field.Name} did not implement {nameof(KeyedCollection<string, CustomField>)}.");
                        }
                        field.IsSelected = false;
                    }
                    else if (string.IsNullOrEmpty(field.Name))
                    {
                        field.IsSelected = false;
                    }
                }
            }
            return query;
        }

        /// <summary>
        /// Get all ExecutionQuery fields.
        /// </summary>
        /// <param name="dataType">The data type.</param>
        /// <param name="selectedFields">The selected fields</param>
        /// <returns>Returns an <see cref="ExecutionQueryField"/> collection.</returns>
        /// <exception cref="Sdk4meInvalidFieldNameException"></exception>
        private static List<ExecutionQueryField> GetExecutionQueryFields(Type dataType, ImmutableHashSet<string>? selectedFields)
        {
            List<ExecutionQueryField> retval = new();

            PropertyInfo[] allProperties = dataType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Where(x => !x.PropertyType.IsInterface).ToArray();
            foreach (PropertyInfo propertyInfo in allProperties)
            {
                if (propertyInfo.GetCustomAttribute(typeof(JsonPropertyAttribute)) is JsonPropertyAttribute jsonProperty && jsonProperty.PropertyName is string jsonPropertyName)
                {
                    retval.Add(new(jsonPropertyName, propertyInfo)
                    {
                        IsDefault = (propertyInfo.GetCustomAttribute(typeof(Sdk4meFieldAttribute)) is Sdk4meFieldAttribute sdk4meDefaultField) && sdk4meDefaultField.IsDefaultQueryProperty,
                        IsSelected = selectedFields != null && selectedFields.Contains(jsonPropertyName)
                    });
                }
            }

            if (selectedFields != null)
            {
                foreach (string selectedField in selectedFields)
                {
                    if (selectedField != "*" && retval.FirstOrDefault(x => x.Name == selectedField) == null)
                    {
                        throw new Sdk4meInvalidFieldNameException(selectedField);
                    }
                }
            }

            if (selectedFields == null || selectedFields.Count.Equals(0))
            {
                foreach (ExecutionQueryField field in retval)
                    field.IsSelected = field.IsDefault;
            }
            else if (selectedFields.Contains("*"))
            {
                foreach (ExecutionQueryField field in retval)
                    field.IsSelected = !field.IsConnection;
            }

            if (retval.FirstOrDefault(x => x.Name == "id") is ExecutionQueryField queryField)
            {
                if (dataType.GetCustomAttribute(typeof(Sdk4meEntityAttribute)) is Sdk4meEntityAttribute attribute && attribute.IgnoreIdentifier)
                    queryField.IsSelected = false;
                else
                    queryField.IsSelected = true;
            }

            return retval;
        }

        /// <summary>
        /// Build a GraphQL <see cref="DateTime"/> filter.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator</param>
        /// <param name="values">The <see cref="DateTime"/> values.</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        /// <exception cref="Sdk4meFilterException"></exception>
        internal static string BuildDateTimeFilter(string field, FilterOperator filterOperator, params DateTime?[] values)
        {
            string[] serializedValue = SerializeObject(values);

            if (filterOperator.IsCommonOperator())
            {
                return BuildStringFilter(field, filterOperator, serializedValue);
            }           
            else if (filterOperator.IsDateTimeSingleValueOperator() && serializedValue.Length.Equals(1))
            {
                switch (filterOperator)
                {
                    case FilterOperator.LessThan:
                        return $"{field}:{{lessThan:{serializedValue[0]}}}";
                    case FilterOperator.LessThanOrEqualsTo:
                        return $"{field}:{{lessThanOrEqualTo:{serializedValue[0]}}}";
                    case FilterOperator.GreaterThan:
                        return $"{field}:{{greaterThanOrEqualTo:{serializedValue[0]}}}";
                    case FilterOperator.GreaterThanOrEqualsTo:
                        return $"{field}:{{greaterThanOrEqualTo:{serializedValue[0]}}}";
                }
            }
            else if (filterOperator.IsDateTimeRangeOperator() && serializedValue.Length.Equals(2))
            {
                switch (filterOperator)
                {
                    case FilterOperator.GreaterThanAndLessThan:
                        return $"{field}:{{greaterThan:{serializedValue[0]} lessThan:{serializedValue[1]}}}";
                    case FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo:
                        return $"{field}:{{greaterThanOrEqualTo:{serializedValue[0]} lessThanOrEqualTo:{serializedValue[1]}}}";
                }
            }

            throw new Sdk4meFilterException($"Unsupported date time filter operator, use " +
                $"{nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, {nameof(FilterOperator.In)}, or {nameof(FilterOperator.NotIn)} with one or multiple values, use {nameof(FilterOperator.LessThan)}, " +
                $"{nameof(FilterOperator.LessThanOrEqualsTo)}, {nameof(FilterOperator.GreaterThan)} or {nameof(FilterOperator.GreaterThanOrEqualsTo)} with a single value, and use {nameof(FilterOperator.GreaterThanAndLessThan)} or " +
                $"{nameof(FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo)} with two values.");
        }

        /// <summary>
        /// Build a GraphQL <see cref="bool"/> filter.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator</param>
        /// <param name="value">The <see cref="bool"/> values.</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        /// <exception cref="Sdk4meFilterException"></exception>
        internal static string BuildBooleanFilter(string field, FilterOperator filterOperator, bool value)
        {
            return filterOperator switch
            {
                FilterOperator.Equals or FilterOperator.In => $"{field}:{JsonConvert.SerializeObject(value)}",
                FilterOperator.NotEquals or FilterOperator.NotIn => $"{field}:{JsonConvert.SerializeObject(!value)}",
                _ => throw new Sdk4meFilterException($"Unsupported boolean filter operator. Supported operators are {nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, {nameof(FilterOperator.In)}, or {nameof(FilterOperator.NotIn)}."),
            };
        }

        /// <summary>
        /// Build a GraphQL FreeFormatFilter.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value.</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        internal static string BuildFreeFormatFilter(string? value)
        {
            return value == null ? string.Empty : $"query:{SerializeObject(value)}";
        }

        /// <summary>
        /// Build a GraphQL Custom filter.
        /// </summary>
        /// <param name="name">The custom filter name.</param>
        /// <param name="filterOperator">The filter operator</param>
        /// <param name="values">The <see cref="string"/> values.</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        /// <exception cref="Sdk4meFilterException"></exception>
        internal static string BuildCustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            StringBuilder builder = new($"{{name:{SerializeObject(name)} ");
            if (filterOperator.IsCommonOperator())
            {
                string[] serializedValues = SerializeObject(values).Distinct().ToArray();

                builder.Append(filterOperator.IsNegateOperator() ? "negate:true values:" : "values:");
                builder.Append(serializedValues.Length switch
                {
                    0 => "[]",
                    1 => $"[{serializedValues[0]}]",
                    _ => $"[{string.Join(",", serializedValues)}]"
                });
                builder.Append('}');
            }
            else if (filterOperator == FilterOperator.Present)
            {
                builder.Append("negate:true values:[null]}");
            }
            else if (filterOperator == FilterOperator.Empty)
            {
                builder.Append("values:[null]}");
            }
            else
            {
                throw new Sdk4meFilterException($"Unsupported custom filter operator. Supported operators include " +
                    $"{nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, {nameof(FilterOperator.In)}, {nameof(FilterOperator.NotIn)}, " +
                    $"{nameof(FilterOperator.Present)}, and {nameof(FilterOperator.Empty)}.");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Build a GraphQL non-value filter.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        /// <exception cref="Sdk4meFilterException"></exception>
        internal static string BuildStringFilter(string field, FilterOperator filterOperator)
        {
            if (filterOperator.IsNullableOperator())
                return BuildStringFilter(field, filterOperator, Array.Empty<string>());

            throw new Sdk4meFilterException($"Unsupported string filter operator. Please use either {nameof(FilterOperator.Present)} or {nameof(FilterOperator.Empty)} when no values are provided.");
        }

        /// <summary>
        /// Build a GraphQL <see cref="string"/> filter.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The <see cref="string"/> values.</param>
        /// <returns>A partial GraphQL filter statement.</returns>
        /// <exception cref="Sdk4meFilterException"></exception>
        internal static string BuildStringFilter(string field, FilterOperator filterOperator, params string?[] values)
        {
            if (field == "id" && values.Any(value => value == null))
                throw new Sdk4meFilterException("All values must be non-null when the field ID is specified for filtering.");

            StringBuilder builder = new($"{field}:");
            if (filterOperator.IsCommonOperator())
            {
                string[] serializedValues = SerializeObject(values);
                builder.Append(filterOperator.IsNegateOperator() ? "{negate:true values:" : "{values:");
                builder.Append(serializedValues.Length switch
                {
                    0 => "[]",
                    1 => $"[{serializedValues[0]}]",
                    _ => $"[{string.Join(",", serializedValues)}]"
                });
                builder.Append('}');
            }
            else if (filterOperator == FilterOperator.Present)
            {
                builder.Append("{negate:true values:[]}");
            }
            else if (filterOperator == FilterOperator.Empty)
            {
                builder.Append("{values:[]}");
            }
            else
            {
                throw new Sdk4meFilterException($"Unsupported string filter operator. Supported operators include " +
                    $"{nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, {nameof(FilterOperator.In)}, {nameof(FilterOperator.NotIn)}, " +
                    $"{nameof(FilterOperator.Present)}, and {nameof(FilterOperator.Empty)}.");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Serializes a nullable string value to its JSON representation.
        /// If the input value is null, it returns the string "null".
        /// </summary>
        /// <param name="value">The nullable string to serialize.</param>
        /// <returns>A JSON-formatted string representation of the input value or "null".</returns>
        private static string SerializeObject(string? value)
        {
            return (value == null) ? "null" : JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// Serializes an array of nullable strings into an array of JSON-formatted strings.
        /// Handles null arrays by returning an empty array of strings.
        /// </summary>
        /// <param name="values">The array of nullable strings to serialize.</param>
        /// <returns>An array of JSON-formatted string representations of the input values.</returns>
        private static string[] SerializeObject(params string?[] values)
        {
            List<string> retval = new();
            values ??= Array.Empty<string>();
            foreach (string? value in values)
                retval.Add(SerializeObject(value));
            return retval.ToArray();
        }

        /// <summary>
        /// Serializes an array of nullable DateTime values into an array of JSON-formatted strings.
        /// Null DateTime values are represented as the string "null".
        /// </summary>
        /// <param name="values">The array of nullable DateTime values to serialize.</param>
        /// <returns>An array of JSON-formatted string representations of the input DateTime values.</returns>
        private static string[] SerializeObject(params DateTime?[] values)
        {
            List<string> retval = new();
            foreach (DateTime? value in values)
            {
                if (value == null)
                    retval.Add("null");
                else
                    retval.Add(JsonConvert.SerializeObject(value));
            }
            return retval.ToArray();
        }
    }
}
