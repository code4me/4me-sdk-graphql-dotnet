namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new custom collection.
    /// </summary>
    internal class CustomCollectionCreateMutation : Mutation<CustomCollectionCreatePayload, CustomCollectionCreateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal CustomCollectionCreateMutation(CustomCollectionCreateInput data, CustomCollectionQuery query)
            : base("customCollectionCreate", "CustomCollectionCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(CustomCollectionQuery query)
        {
            query.FieldName = "customCollection";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
