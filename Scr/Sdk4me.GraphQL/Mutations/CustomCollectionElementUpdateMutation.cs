namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing custom collection element.
    /// </summary>
    internal class CustomCollectionElementUpdateMutation : Mutation<CustomCollectionElementUpdatePayload, CustomCollectionElementUpdateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionElementUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal CustomCollectionElementUpdateMutation(CustomCollectionElementUpdateInput data, CustomCollectionElementQuery query)
            : base("customCollectionElementUpdate", "CustomCollectionElementUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() {query};
        }
    }
}
