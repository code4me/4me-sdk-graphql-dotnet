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
        /// The account this record belongs to.
        /// </summary>
        public ScrumWorkspaceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        public ScrumWorkspaceQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
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
        /// Product backlog used when planning sprints.
        /// </summary>
        public ScrumWorkspaceQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
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

        /// <summary>
        /// Team planning their work using this scrum workspace.
        /// </summary>
        public ScrumWorkspaceQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
