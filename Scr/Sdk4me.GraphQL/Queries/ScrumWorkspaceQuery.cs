namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ScrumWorkspace records.
    /// </summary>
    public class ScrumWorkspaceQuery : Query<ScrumWorkspaceQuery, ScrumWorkspaceField, ScrumWorkspaceView, ScrumWorkspaceOrderField>
    {
        /// <summary>
        /// Initialize a new scrum workspace query instance.
        /// </summary>
        public ScrumWorkspaceQuery()
            : base("scrumWorkspaces", typeof(ScrumWorkspace), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public ScrumWorkspaceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Sprints of this scrum workspace.
        /// </summary>
        public ScrumWorkspaceQuery SelectSprints(SprintQuery query)
        {
            query.FieldName = "sprints";
            return Select(query);
        }
    }
}
