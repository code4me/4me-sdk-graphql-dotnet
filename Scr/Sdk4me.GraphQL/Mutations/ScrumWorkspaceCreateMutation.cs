namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new scrum workspace.
    /// </summary>
    internal class ScrumWorkspaceCreateMutation : Mutation<ScrumWorkspaceCreatePayload, ScrumWorkspaceCreateInput>
    {
        /// <summary>
        /// Initialize an new ScrumWorkspaceCreate mutation instance.
        /// </summary>
        internal ScrumWorkspaceCreateMutation(ScrumWorkspaceCreateInput data)
            : base("scrumWorkspaceCreate", "ScrumWorkspaceCreateInput!", data, new HashSet<IQuery>() { new ScrumWorkspaceQuery() { FieldName = "scrumWorkspace", IsConnection = false }.Select("*") })
        {
        }
    }
}
