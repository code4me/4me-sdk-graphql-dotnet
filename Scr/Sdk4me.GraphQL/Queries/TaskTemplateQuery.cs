namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TaskTemplate records.
    /// </summary>
    public class TaskTemplateQuery : Query<TaskTemplateQuery, TaskTemplateField, TaskTemplateView, TaskTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new task template query instance.
        /// </summary>
        public TaskTemplateQuery()
            : base("taskTemplates", typeof(TaskTemplate), true)
        {
        }

        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        public TaskTemplateQuery SelectApprovals(TaskTemplateApprovalQuery query)
        {
            query.FieldName = "approvals";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public TaskTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the task template.
        /// </summary>
        public TaskTemplateQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public TaskTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public TaskTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Service instances of the task template.
        /// </summary>
        public TaskTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Tasks created using the task template.
        /// </summary>
        public TaskTemplateQuery SelectTasks(TaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }

        /// <summary>
        /// Workflow templates that include the task template.
        /// </summary>
        public TaskTemplateQuery SelectWorkflowTemplates(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplates";
            return Select(query);
        }
    }
}
