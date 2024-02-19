namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me GraphQL mutation.
    /// </summary>
    /// <typeparam name="TOutEntity">Any type implementing <see cref="Payload"/>.</typeparam>
    /// <typeparam name="TInEntity">Any type implementing <see cref="PropertyChangeSet"/>.</typeparam>
    public abstract class Mutation<TOutEntity, TInEntity>
        where TOutEntity : Payload
        where TInEntity : PropertyChangeSet
    {
        private readonly string fieldName = string.Empty;
        private readonly string dataTypeName = string.Empty;
        private readonly HashSet<IQuery> queries = new();
        private readonly TInEntity data;

        /// <summary>
        /// Get the query data type.
        /// </summary>
        public string DataTypeName
        {
            get => dataTypeName;
        }

        /// <summary>
        /// Gets the field name.
        /// </summary>
        public string FieldName
        {
            get => fieldName;
        }

        /// <summary>
        /// Gets the input data.
        /// </summary>
        public TInEntity Data
        {
            get => data;
        }

        /// <summary>
        /// The response queries.
        /// </summary>
        public ImmutableHashSet<IQuery> Queries
        {
            get => queries.ToImmutableHashSet();
        }

        /// <summary>
        /// Create a new Mutation instance.
        /// </summary>
        /// <param name="fieldName">The mutation input field name.</param>
        /// <param name="dataTypeName">The mutation input data type name.</param>
        /// <param name="data">The input data.</param>
        /// <param name="queries">The output selection query.</param>
        protected Mutation(string fieldName, string dataTypeName, TInEntity data, HashSet<IQuery> queries)
        {
            this.fieldName = fieldName;
            this.dataTypeName = dataTypeName;
            this.data = data;
            this.queries = queries;
        }
    }
}
