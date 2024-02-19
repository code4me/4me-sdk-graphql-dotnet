namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing release.
    /// </summary>
    internal class ReleaseUpdateMutation : Mutation<ReleaseUpdatePayload, ReleaseUpdateInput>
    {
        /// <summary>
        /// Initialize an new ReleaseUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ReleaseUpdateMutation(ReleaseUpdateInput data, ReleaseQuery query)
            : base("releaseUpdate", "ReleaseUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReleaseQuery query)
        {
            query.FieldName = "release";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
