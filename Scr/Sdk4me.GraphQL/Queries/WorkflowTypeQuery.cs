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
        /// Initialize a new workflow type query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the workflow type.</param>
        public WorkflowTypeQuery(string id)
            : base("WorkflowType", id, typeof(WorkflowType), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTypeQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTypeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTypeQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
