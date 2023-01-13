namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectTask records.
    /// </summary>
    public class ProjectTaskQuery : Query<ProjectTaskQuery, ProjectTaskField, ProjectTaskView, ProjectTaskOrderField>
    {
        /// <summary>
        /// Initialize a new project task query instance.
        /// </summary>
        public ProjectTaskQuery()
            : base("projectTasks", typeof(ProjectTask), true)
        {
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        public ProjectTaskQuery SelectAssignments(ProjectTaskAssignmentQuery query)
        {
            query.FieldName = "assignments";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ProjectTaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ProjectTaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public ProjectTaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ProjectTaskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        public ProjectTaskQuery SelectPredecessors(ProjectTaskQuery query)
        {
            query.FieldName = "predecessors";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public ProjectTaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Successors of the project task.
        /// </summary>
        public ProjectTaskQuery SelectSuccessors(ProjectTaskQuery query)
        {
            query.FieldName = "successors";
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public ProjectTaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }
    }
}
