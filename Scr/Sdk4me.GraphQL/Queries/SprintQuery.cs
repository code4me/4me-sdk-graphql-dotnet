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
        /// Initialize a new sprint query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the sprint.</param>
        public SprintQuery(string id)
            : base("Sprint", id, typeof(Sprint), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SprintQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SprintQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Scrum workspace this sprint belongs to.
        /// </summary>
        /// <param name="query">The scrum workspace query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SprintQuery SelectScrumWorkspace(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspace";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Items in this sprint.
        /// </summary>
        /// <param name="query">The sprint backlog item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SprintQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }
    }
}
