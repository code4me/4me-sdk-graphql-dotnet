namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing custom collection.
    /// </summary>
    internal class CustomCollectionUpdateMutation : Mutation<CustomCollectionUpdatePayload, CustomCollectionUpdateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal CustomCollectionUpdateMutation(CustomCollectionUpdateInput data, CustomCollectionQuery query)
            : base("customCollectionUpdate", "CustomCollectionUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
