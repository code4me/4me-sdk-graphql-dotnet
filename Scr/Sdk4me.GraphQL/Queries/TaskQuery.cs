namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Task records.
    /// </summary>
    public class TaskQuery : Query<TaskQuery, TaskField, TaskView, TaskOrderField>
    {
        /// <summary>
        /// Initialize a new task query instance.
        /// </summary>
        public TaskQuery()
            : base("tasks", typeof(Task), true)
        {
        }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        public TaskQuery SelectApprovals(TaskApprovalQuery query)
        {
            query.FieldName = "approvals";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public TaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the task.
        /// </summary>
        public TaskQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public TaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public TaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public TaskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Service instances of the task.
        /// </summary>
        public TaskQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public TaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public TaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }
    }
}
