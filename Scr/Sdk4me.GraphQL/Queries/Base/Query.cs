using System.ComponentModel;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me GraphQL query.
    /// </summary>
    /// <typeparam name="TEntity">Any type implementing <see cref="Node"/>.</typeparam>
    /// <typeparam name="TFields">Any enumerator.</typeparam>
    /// <typeparam name="TView">Any enumerator.</typeparam>
    /// <typeparam name="TOrderBy">Any enumerator.</typeparam>
    public abstract class Query<TEntity, TFields, TView, TOrderBy> : IQuery
    where TEntity : Query<TEntity, TFields, TView, TOrderBy>
    where TFields : Enum
    where TView : Enum
    where TOrderBy : Enum
    {
        private readonly HashSet<string> fields = new();
        private readonly Type dataType = typeof(TEntity);
        private readonly Dictionary<string, IQuery> queries = new();
        private readonly HashSet<string> filters = new();
        private readonly HashSet<string> customFilters = new();
        private string fieldName = string.Empty;
        private string view = string.Empty;
        private string orderByOrder = string.Empty;
        private string orderByField = string.Empty;
        private int? itemsPerRequest;
        private bool isConnection = false;

        /// <summary>
        /// Get the query data type.
        /// </summary>
        public Type DataType
        {
            get => dataType;
        }

        /// <summary>
        /// Gets the field name.
        /// </summary>
        public string FieldName
        {
            get => fieldName;
            internal set => fieldName = value;
        }

        /// <summary>
        /// Get all selected fields.
        /// </summary>
        public ImmutableHashSet<string> SelectedFields
        {
            get => fields.ToImmutableHashSet();
        }

        /// <summary>
        /// Get the selected view.
        /// <br>Returns <see cref="string.Empty"/> when no view is selected.</br>
        /// </summary>
        public string SelectedView
        {
            get => view;
        }

        /// <summary>
        /// Get the selected order by field.
        /// <br>Returns <see cref="string.Empty"/> when no field is selected.</br>
        /// </summary>
        public string SelectedOrderByField
        {
            get => orderByField;
        }

        /// <summary>
        /// Get the selected order by order.
        /// <br>Returns <see cref="string.Empty"/> when no sort order is selected.</br>
        /// </summary>
        public string SelectedOrderByOrder
        {
            get => orderByOrder;
        }

        /// <summary>
        /// Get the number of objects returned per API call.
        /// </summary>
        public int? SelectedItemsPerRequest
        {
            get => itemsPerRequest;
        }

        /// <summary>
        /// Returns true when the field is a connection.
        /// </summary>
        public bool IsConnection
        {
            get => isConnection;
            internal set => isConnection = value;
        }

        /// <summary>
        /// Get all selected non-primitive data type fields.
        /// </summary>
        public ImmutableHashSet<IQuery> Queries
        {
            get => queries.Values.ToImmutableHashSet();
        }

        /// <summary>
        /// Get all filters.
        /// </summary>
        public ImmutableHashSet<string> Filters
        {
            get => filters.ToImmutableHashSet();
        }

        /// <summary>
        /// Get all custom filters.
        /// </summary>
        public ImmutableHashSet<string> CustomFilters
        {
            get => customFilters.ToImmutableHashSet();
        }

        /// <summary>
        /// Create a new Query instance.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="dataType">The query data type.</param>
        /// <param name="isConnection">True when the field is a connection, otherwise false.</param>
        /// <exception cref="Sdk4meException"></exception>
        protected Query(string fieldName, Type dataType, bool isConnection)
        {
            this.fieldName = fieldName;
            this.dataType = typeof(Node).IsAssignableFrom(dataType) ? dataType : throw new Sdk4meException($"{nameof(dataType)} does not implement {nameof(Node)}");
            this.isConnection = isConnection;
        }

        /// <summary>
        /// Set the on which field the response should be ordered, and the sort order.
        /// </summary>
        /// <param name="value">The field name.</param>
        /// <param name="orderBySortOrder">The sort order.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity OrderBy(string value, OrderBySortOrder orderBySortOrder)
        {
            orderByField = value;
            orderByOrder = orderBySortOrder switch
            {
                OrderBySortOrder.Ascending => "asc",
                OrderBySortOrder.Descending => "desc",
                _ => string.Empty
            };
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Set the on which field the response should be ordered, and the sort order.
        /// </summary>
        /// <param name="value">The field name.</param>
        /// <param name="orderBySortOrder">The sort order.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity OrderBy(TOrderBy value, OrderBySortOrder orderBySortOrder)
        {
            return OrderBy(GetEnumStringValue(value), orderBySortOrder);
        }

        /// <summary>
        /// Set the view to be used.
        /// </summary>
        /// <param name="value">The view value.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity View(string value)
        {
            view = value;
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Set the view to be used.
        /// </summary>
        /// <param name="value">The view value.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity View(TView value)
        {
            return View(GetEnumStringValue(value));
        }

        /// <summary>
        /// Set the number of objects returned per API call.
        /// </summary>
        /// <param name="itemsPerRequest">The number of items.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity ItemsPerRequest(int itemsPerRequest)
        {
            if (itemsPerRequest <= 0)
                this.itemsPerRequest = 1;
            else if (itemsPerRequest > 100)
                this.itemsPerRequest = 100;
            else
                this.itemsPerRequest = itemsPerRequest;
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add one or more fields to the current query.
        /// </summary>
        /// <param name="fields">The field names.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Select(params string[] fields)
        {
            foreach (string field in fields)
                this.fields.Add(field);
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add one or more fields to the current query.
        /// </summary>
        /// <param name="fields">The field names.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Select(params TFields[] fields)
        {
            foreach (TFields field in fields)
                this.fields.Add(GetEnumStringValue(field));
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add all non-connection fields to the current query.
        /// <para>Warning: this will impact performance. Try to select the required fields.</para>
        /// </summary>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity SelectAll()
        {
            return Select("*");
        }

        /// <summary>
        /// Add a collection or non-primitive field to the current query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        internal protected TEntity Select(IQuery query)
        {
            if (queries.ContainsKey(query.FieldName))
                queries[query.FieldName] = query;
            else
                queries.Add(query.FieldName, query);
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(string field, FilterOperator filterOperator, params string[] values)
        {
            filters.Add(ExecutionQueryBuilder.BuildStringFilter(field, filterOperator, values));
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(TFields field, FilterOperator filterOperator, params string[] values)
        {
            return Filter(GetEnumStringValue(field), filterOperator, values);
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(string field, FilterOperator filterOperator, params DateTime[] values)
        {
            filters.Add(ExecutionQueryBuilder.BuildDateTimeFilter(field, filterOperator, values));
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(TFields field, FilterOperator filterOperator, params DateTime[] values)
        {
            return Filter(GetEnumStringValue(field), filterOperator, values);
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="value">The filter value.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(string field, FilterOperator filterOperator, bool value)
        {
            filters.Add(ExecutionQueryBuilder.BuildBooleanFilter(field, filterOperator, value));
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        /// <summary>
        /// Add a filter to the query.
        /// </summary>
        /// <param name="field">The field name.</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="value">The filter value.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        public TEntity Filter(TFields field, FilterOperator filterOperator, bool value)
        {
            return Filter(GetEnumStringValue(field), filterOperator, value);
        }

        /// <summary>
        /// Add a custom filter to the query.
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <returns>The current <see cref="IQuery"/>.</returns>
        /// <exception cref="NullReferenceException"></exception>
        internal protected TEntity AddCustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            customFilters.Add(ExecutionQueryBuilder.BuildCustomFilter(name, filterOperator, values));
            return this as TEntity ?? throw new NullReferenceException(nameof(TEntity));
        }

        private static string GetEnumStringValue(Enum value)
        {
            return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault()?.Value ?? value.ToString();
        }
    }
}
