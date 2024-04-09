namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving WorkflowTemplate records.
    /// </summary>
    public class WorkflowTemplateQuery : Query<WorkflowTemplateQuery, WorkflowTemplateField, WorkflowTemplateView, WorkflowTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new workflow template query instance.
        /// </summary>
        public WorkflowTemplateQuery()
            : base("workflowTemplates", typeof(WorkflowTemplate), true)
        {
        }

        /// <summary>
        /// Initialize a new workflow template query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the workflow template.</param>
        public WorkflowTemplateQuery(string id)
            : base("WorkflowTemplate", id, typeof(WorkflowTemplate), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Phases of the workflow template.
        /// </summary>
        /// <param name="query">The workflow template phase query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectPhases(WorkflowTemplatePhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// Recurrency for the workflow template.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectRecurrence(RecurrenceQuery query)
        {
            query.FieldName = "recurrence";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Task template relations of the workflow template
        /// </summary>
        /// <param name="query">The workflow task template relation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectTaskTemplateRelations(WorkflowTaskTemplateRelationQuery query)
        {
            query.FieldName = "taskTemplateRelations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is to be added to a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectWorkflowManager(PersonQuery query)
        {
            query.FieldName = "workflowManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Workflows of the workflow template.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectWorkflows(WorkflowQuery query)
        {
            query.FieldName = "workflows";
            return Select(query);
        }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The workflow type query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplateQuery SelectWorkflowType(WorkflowTypeQuery query)
        {
            query.FieldName = "workflowType";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
