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
        /// The account this record belongs to.
        /// </summary>
        public ProjectTaskTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// The effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
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
        /// The PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectPdfDesign(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
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
        /// The skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectSkillPool(SkillPoolQuery query)
        {
            query.FieldName = "skillPool";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
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

        /// <summary>
        /// The Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension that is to be added to a new project task when it is being created based on the template.
        /// </summary>
        public ProjectTaskTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
