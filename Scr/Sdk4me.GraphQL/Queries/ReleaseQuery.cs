namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Release records.
    /// </summary>
    public class ReleaseQuery : Query<ReleaseQuery, ReleaseField, ReleaseView, ReleaseOrderField>
    {
        /// <summary>
        /// Initialize a new release query instance.
        /// </summary>
        public ReleaseQuery()
            : base("releases", typeof(Release), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReleaseQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReleaseQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Workflows of the release.
        /// </summary>
        public ReleaseQuery SelectWorkflows(WorkflowQuery query)
        {
            query.FieldName = "workflows";
            return Select(query);
        }
    }
}
