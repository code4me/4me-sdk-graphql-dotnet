namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Project records.
    /// </summary>
    public class ProjectQuery : Query<ProjectQuery, ProjectField, ProjectView, ProjectOrderField>
    {
        /// <summary>
        /// Initialize a new project query instance.
        /// </summary>
        public ProjectQuery()
            : base("projects", typeof(Project), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ProjectQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ProjectQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ProjectQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Phases of the project.
        /// </summary>
        public ProjectQuery SelectPhases(ProjectPhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// Problems of the project.
        /// </summary>
        public ProjectQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// Requests of the project.
        /// </summary>
        public ProjectQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Risks of the project.
        /// </summary>
        public ProjectQuery SelectRisks(RiskQuery query)
        {
            query.FieldName = "risks";
            return Select(query);
        }

        /// <summary>
        /// Tasks of the project.
        /// </summary>
        public ProjectQuery SelectTasks(ProjectTaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }

        /// <summary>
        /// Workflows of the project.
        /// </summary>
        public ProjectQuery SelectWorkflows(WorkflowQuery query)
        {
            query.FieldName = "workflows";
            return Select(query);
        }
    }
}
