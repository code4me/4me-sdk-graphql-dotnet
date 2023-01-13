namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Workflow records.
    /// </summary>
    public class WorkflowQuery : Query<WorkflowQuery, WorkflowField, WorkflowView, WorkflowOrderField>
    {
        /// <summary>
        /// Initialize a new workflow query instance.
        /// </summary>
        public WorkflowQuery()
            : base("workflows", typeof(Workflow), true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public WorkflowQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public WorkflowQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public WorkflowQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public WorkflowQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Phases of the workflow.
        /// </summary>
        public WorkflowQuery SelectPhases(WorkflowPhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// All problems of this workflow.
        /// </summary>
        public WorkflowQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// All requests of this workflow.
        /// </summary>
        public WorkflowQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// All tasks of this workflow.
        /// </summary>
        public WorkflowQuery SelectTasks(TaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }
    }
}
