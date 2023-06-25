namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Sprint records.
    /// </summary>
    public class SprintQuery : Query<SprintQuery, SprintField, SprintView, SprintOrderField>
    {
        /// <summary>
        /// Initialize a new sprint query instance.
        /// </summary>
        public SprintQuery()
            : base("sprints", typeof(Sprint), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public SprintQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public SprintQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Scrum workspace this sprint belongs to.
        /// </summary>
        public SprintQuery SelectScrumWorkspace(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspace";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Items in this sprint.
        /// </summary>
        public SprintQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }
    }
}
