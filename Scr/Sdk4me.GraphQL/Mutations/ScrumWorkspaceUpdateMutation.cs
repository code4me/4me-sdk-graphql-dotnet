namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing scrum workspace.
    /// </summary>
    internal class ScrumWorkspaceUpdateMutation : Mutation<ScrumWorkspaceUpdatePayload, ScrumWorkspaceUpdateInput>
    {
        /// <summary>
        /// Initialize an new ScrumWorkspaceUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal ScrumWorkspaceUpdateMutation(ScrumWorkspaceUpdateInput data, ScrumWorkspaceQuery query)
            : base("scrumWorkspaceUpdate", "ScrumWorkspaceUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspace";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
