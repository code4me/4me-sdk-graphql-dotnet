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
        /// Initialize a new scrum workspace query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the scrum workspace.</param>
        public ScrumWorkspaceQuery(string id)
            : base("ScrumWorkspace", id, typeof(ScrumWorkspace), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Product backlog used when planning sprints.
        /// </summary>
        /// <param name="query">The product backlog query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Sprints of this scrum workspace.
        /// </summary>
        /// <param name="query">The sprint query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectSprints(SprintQuery query)
        {
            query.FieldName = "sprints";
            return Select(query);
        }

        /// <summary>
        /// Team planning their work using this scrum workspace.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ScrumWorkspaceQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
