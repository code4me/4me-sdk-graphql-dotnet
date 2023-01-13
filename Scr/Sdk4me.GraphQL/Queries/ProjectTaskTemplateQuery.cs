namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectTaskTemplate records.
    /// </summary>
    public class ProjectTaskTemplateQuery : Query<ProjectTaskTemplateQuery, ProjectTaskTemplateField, ProjectTaskTemplateView, ProjectTaskTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new project task template query instance.
        /// </summary>
        public ProjectTaskTemplateQuery()
            : base("projectTaskTemplates", typeof(ProjectTaskTemplate), true)
        {
        }

        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectAssignments(ProjectTaskTemplateAssignmentQuery query)
        {
            query.FieldName = "assignments";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ProjectTaskTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public ProjectTaskTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public ProjectTaskTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Project templates that include the project task template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectProjectTemplates(ProjectTemplateQuery query)
        {
            query.FieldName = "projectTemplates";
            return Select(query);
        }

        /// <summary>
        /// Project tasks created using the project task template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectTasks(ProjectTaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }
    }
}
