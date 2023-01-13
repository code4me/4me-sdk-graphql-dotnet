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
        /// <returns>An <see cref="ExecutionQuery"/> based on the GraphQL query.</returns>
        /// <exception cref="Sdk4meInvalidFieldNameException"></exception>
        internal static ExecutionQuery BuildQuery(IQuery query, int defaultItemsPerRequest)
        {
            if (query.FieldName == string.Empty)
                throw new Sdk4meInvalidFieldNameException($"{nameof(query)} first field is not a root query field.");

            return BuildQuery(query, 0, defaultItemsPerRequest);
        }

        /// <summary>
        /// Get the GraphQL mutation query.
        /// </summary>
        /// <typeparam name="TOutEntity">Any type being class.</typeparam>
        /// <typeparam name="TInEntity">Any type implementing <see cref="PropertyChangeSet"/> and implemented the <see cref="Sdk4meEntityAttribute.PayloadFieldName"/>.</typeparam>
        /// <param name="input">The input data.</param>
        /// <returns>An <see cref="ExecutionQuery"/> based on the GraphQL query.</returns>
        /// <exception cref="Sdk4meInvalidFieldNameException"></exception>
        internal static string GetGraphQLQuery<TOutEntity, TInEntity>(Mutation<TOutEntity, TInEntity> input)
            where TOutEntity : class
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
        /// <returns>The GraphQL query.</returns>
        internal static string GetGraphQLQuery(ExecutionQuery executionQuery)
        {
            StringBuilder builder = new();

            if (executionQuery.IsConnection)
            {
                builder.Append(executionQuery.FieldName);
                builder.Append('(');
                builder.Append($"first:{executionQuery.ItemsPerRequest}");

                if (executionQuery.Depth.Equals(0))
                {
                    if (executionQuery.Filters.Count > 0)
                        builder.Append($" filter:{{{string.Join(" ", executionQuery.Filters)}}}");

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
                        throw new Sdk4meException($"Pagination not possible, {executionQuery.FieldName} has no identifier");
                    builder.Append("id ");
                }
                else
                {
                    string fields = string.Join(" ", executionQuery.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                    builder.Append(fields);
                    builder.Append(fields != string.Empty && executionQuery.Queries.Any() ? " " : "");
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

                    string fields = string.Join(" ", executionQuery.Fields.Where(x => x.IsSelected).Select(x => x.Name));
                    builder.Append(fields);
                    builder.Append(fields != string.Empty && executionQuery.Queries.Any() ? " " : "");

                    HashSet<string> subQueries = new();
                    foreach (ExecutionQuery query in executionQuery.Queries)
                        subQueries.Add(GetGraphQLQuery(query));
                    subQueries.RemoveWhere(x => string.IsNullOrWhiteSpace(x));
                    builder.Append(string.Join(" ", subQueries));

                    builder.Append('}');
                }
            }

            return builder.ToString();
        }

        private static ExecutionQuery BuildQuery(IQuery query, int depth, int defaultItemsPerRequest)
        {
            ExecutionQuery retval = new(query.FieldName, query.DataType)
            {
                View = query.SelectedView,
                OrderByField = query.SelectedOrderByField,
                OrderByOrder = query.SelectedOrderByOrder,
                ItemsPerRequest = query.SelectedItemsPerRequest ?? defaultItemsPerRequest,
                Filters = query.Filters.ToHashSet(),
                Fields = GetExecutionQueryFields(query.DataType, query.SelectedFields),
                IsConnection = query.IsConnection,
                Depth = depth
            };

            foreach (IQuery subQuery in query.Queries)
                retval.Queries.Add(BuildQuery(subQuery, depth + 1, defaultItemsPerRequest));

            BuildQuery(retval);
            return retval;
        }

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
                            throw new ApplicationException($"{field.Name} did not implement KeyedCollection<string, CustomField>");
                        }
                        field.IsSelected = false;
                    }
                    else if (field.Name == string.Empty)
                    {
                        field.IsSelected = false;
                    }
                }
            }
            return query;
        }

        private static List<ExecutionQueryField> GetExecutionQueryFields(Type dataType, ImmutableHashSet<string>? selectedFields)
        {
            List<ExecutionQueryField> retval = new();

            PropertyInfo[] allProperties = dataType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo propertyInfo in allProperties)
            {
                if (propertyInfo.GetCustomAttribute(typeof(JsonPropertyAttribute)) is JsonPropertyAttribute jsonProperty && jsonProperty.PropertyName is string jsonPropertyName)
                {
                    retval.Add(new(jsonPropertyName, propertyInfo)
                    {
                        IsDefault = (propertyInfo.GetCustomAttribute(typeof(Sdk4meFieldAttribute)) is Sdk4meFieldAttribute sdk4meDefaultField) && sdk4meDefaultField.IsDefault,
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

        internal static string BuildDateTimeFilter(string field, FilterOperator filterOperator, params DateTime[] values)
        {
            string[] serializedValue = SerializeObject(values);

            if (filterOperator == FilterOperator.In || filterOperator == FilterOperator.NotIn || filterOperator == FilterOperator.Equals || filterOperator == FilterOperator.NotEquals)
            {
                return BuildStringFilter(field, filterOperator, serializedValue);
            }
            else if (serializedValue.Length.Equals(1))
            {
                return filterOperator switch
                {
                    FilterOperator.LessThan => $"{field}:{{lessThan:{serializedValue[0]}}}",
                    FilterOperator.LessThanOrEqualsTo => $"{field}:{{lessThanOrEqualTo:{serializedValue[0]}}}",
                    FilterOperator.GreaterThan => $"{field}:{{greaterThan:{serializedValue[0]}}}",
                    FilterOperator.GreaterThanOrEqualsTo => $"{field}:{{greaterThanOrEqualTo:{serializedValue[0]}}}",
                    _ => throw new Sdk4meFilterException("Invalid DateTime filter operator"),
                };
            }
            else if (serializedValue.Length.Equals(2))
            {
                return filterOperator switch
                {
                    FilterOperator.GreaterThanAndLessThan => $"{field}:{{greaterThan:{serializedValue[0]} lessThan:{serializedValue[1]}}}",
                    FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo => $"{field}:{{greaterThanOrEqualTo:{serializedValue[0]} lessThanOrEqualTo:{serializedValue[1]}}}",
                    _ => throw new Sdk4meFilterException("Invalid DateTime filter operator"),
                };
            }
            else
            {
                throw new Sdk4meFilterException("Unsupported DateTime filter operator");
            }
        }

        internal static string BuildBooleanFilter(string field, FilterOperator filterOperator, bool value)
        {
            if (filterOperator == FilterOperator.Equals || filterOperator == FilterOperator.In)
                return $"{field}:{JsonConvert.SerializeObject(value)}";
            else if (filterOperator == FilterOperator.NotEquals || filterOperator == FilterOperator.NotIn)
                return $"{field}:{JsonConvert.SerializeObject(!value)}";
            else
                throw new Sdk4meFilterException("Invalid boolean filter operator");
        }

        internal static string BuildStringFilter(string field, FilterOperator filterOperator, params string[] values)
        {
            if (filterOperator == FilterOperator.In || filterOperator == FilterOperator.NotIn || filterOperator == FilterOperator.Equals || filterOperator == FilterOperator.NotEquals)
            {
                string[] serializedValue = SerializeObject(values);

                StringBuilder builder = new();
                builder.Append(field);
                if (filterOperator == FilterOperator.NotIn || filterOperator == FilterOperator.NotEquals)
                    builder.Append(":{negate:true values:");
                else
                    builder.Append(":{values:");
                builder.Append(serializedValue.Length switch
                {
                    0 => "[]",
                    1 => $"{serializedValue[0]}",
                    _ => $"[{string.Join(',', serializedValue)}]"
                });
                builder.Append('}');
                return builder.ToString();
            }
            else if (filterOperator == FilterOperator.Present)
            {
                return $"{field}:{{negate:true values:[]}}";
            }
            else if (filterOperator == FilterOperator.Empty)
            {
                return $"{field}:{{values:[]}}";
            }
            else
            {
                throw new Sdk4meFilterException("Invalid filter operator");
            }
        }

        private static string[] SerializeObject(params string[] values)
        {
            List<string> retval = new();
            foreach (string value in values)
                retval.Add(JsonConvert.SerializeObject(value));
            return retval.ToArray();
        }

        private static string[] SerializeObject(params DateTime[] values)
        {
            List<string> retval = new();
            foreach (DateTime value in values)
                retval.Add(JsonConvert.SerializeObject(value));
            return retval.ToArray();
        }
    }
}
