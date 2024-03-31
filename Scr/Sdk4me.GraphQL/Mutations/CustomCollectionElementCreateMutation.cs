namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new custom collection element.
    /// </summary>
    internal class CustomCollectionElementCreateMutation : Mutation<CustomCollectionElementCreatePayload, CustomCollectionElementCreateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionElementCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal CustomCollectionElementCreateMutation(CustomCollectionElementCreateInput data, CustomCollectionElementQuery query)
            : base("customCollectionElementCreate", "CustomCollectionElementCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(CustomCollectionElementQuery query)
        {
            query.FieldName = "customCollectionElement";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
