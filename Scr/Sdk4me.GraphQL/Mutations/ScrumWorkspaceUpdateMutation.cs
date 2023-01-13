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
        internal ScrumWorkspaceUpdateMutation(ScrumWorkspaceUpdateInput data)
            : base("scrumWorkspaceUpdate", "ScrumWorkspaceUpdateInput!", data, new HashSet<IQuery>() { new ScrumWorkspaceQuery() { FieldName = "scrumWorkspace", IsConnection = false }.Select("*") })
        {
        }
    }
}
