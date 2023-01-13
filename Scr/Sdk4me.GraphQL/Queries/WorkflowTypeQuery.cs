namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving WorkflowType records.
    /// </summary>
    public class WorkflowTypeQuery : Query<WorkflowTypeQuery, WorkflowTypeField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new workflow type query instance.
        /// </summary>
        public WorkflowTypeQuery()
            : base("workflowTypes", typeof(WorkflowType), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public WorkflowTypeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public WorkflowTypeQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
