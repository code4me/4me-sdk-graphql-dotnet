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
        /// Files and inline images linked to the description field.
        /// </summary>
        public SprintQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
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
