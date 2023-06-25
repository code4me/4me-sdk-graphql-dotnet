namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The definition to generate a 4me GraphQL query.
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// Get the query data type.
        /// </summary>
        public Type DataType { get; }

        /// <summary>
        /// Gets the field name.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Get all selected fields.
        /// </summary>
        public ImmutableHashSet<string> SelectedFields { get; }

        /// <summary>
        /// Get the selected view.
        /// <br>Returns <see cref="string.Empty"/> when no view is selected.</br>
        /// </summary>
        public string SelectedView { get; }

        /// <summary>
        /// Get the selected order by field.
        /// <br>Returns <see cref="string.Empty"/> when no field is selected.</br>
        /// </summary>
        public string SelectedOrderByField { get; }

        /// <summary>
        /// Get the selected order by order.
        /// <br>Returns <see cref="string.Empty"/> when no sort order is selected.</br>
        /// </summary>
        public string SelectedOrderByOrder { get; }

        /// <summary>
        /// Get the number of objects returned per API call.
        /// </summary>
        public int? SelectedItemsPerRequest { get; }

        /// <summary>
        /// Returns true when the field is an collection.
        /// </summary>
        public bool IsConnection { get; }

        /// <summary>
        /// Get all selected non-primitive data type fields.
        /// </summary>
        public ImmutableHashSet<IQuery> Queries { get; }

        /// <summary>
        /// Get all filters.
        /// </summary>
        public ImmutableHashSet<string> Filters { get; }

        /// <summary>
        /// Get the free format search query filter.
        /// </summary>
        public string QueryFilter { get; }

        /// <summary>
        /// Get all custom filters.
        /// </summary>
        public ImmutableHashSet<string> CustomFilters { get; }
    }
}
