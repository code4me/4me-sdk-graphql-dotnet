namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTaskTemplateRelation">WorkflowTaskTemplateRelation</see> query.
    /// </summary>
    public class WorkflowTaskTemplateRelationQuery : Query<WorkflowTaskTemplateRelationQuery, WorkflowTaskTemplateRelationField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new workflow task template relation query instance.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery()
            : base("", typeof(WorkflowTaskTemplateRelation), true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// The template of the task that will be assigned in case this task is failed or rejected.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery SelectFailureTaskTemplate(TaskTemplateQuery query)
        {
            query.FieldName = "failureTaskTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The phase of the workflow template that the workflow task template is a part of.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery SelectPhase(WorkflowTemplatePhaseQuery query)
        {
            query.FieldName = "phase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Task template related to the workflow template.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery SelectTaskTemplate(TaskTemplateQuery query)
        {
            query.FieldName = "taskTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Workflow template related to the task template.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
