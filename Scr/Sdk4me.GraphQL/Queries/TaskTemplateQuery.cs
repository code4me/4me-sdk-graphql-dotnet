namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TaskTemplate records.
    /// </summary>
    public class TaskTemplateQuery : Query<TaskTemplateQuery, TaskTemplateField, TaskTemplateView, TaskTemplateFilter, TaskTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new task template query instance.
        /// </summary>
        public TaskTemplateQuery()
            : base("taskTemplates", typeof(TaskTemplate), true)
        {
        }

        /// <summary>
        /// Initialize a new task template query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the task template.</param>
        public TaskTemplateQuery(string id)
            : base("TaskTemplate", id, typeof(TaskTemplate), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        /// <param name="query">The task template approval query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectApprovals(TaskTemplateApprovalQuery query)
        {
            query.FieldName = "approvals";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the task template.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a task created based on the template.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// The person who should be selected in the Member field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectPdfDesign(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instance that should be selected in the Request service instance field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectRequestServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "requestServiceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request template that should be selected in the Request template field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The request template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "requestTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instances of the task template.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectSkillPool(SkillPoolQuery query)
        {
            query.FieldName = "skillPool";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Tasks created using the task template.
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectTasks(TaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension that is to be added to a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Workflow templates that include the task template.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TaskTemplateQuery SelectWorkflowTemplates(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplates";
            return Select(query);
        }
    }
}
