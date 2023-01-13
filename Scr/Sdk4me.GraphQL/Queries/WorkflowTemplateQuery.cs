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
        /// Automation rules associated with this record.
        /// </summary>
        public WorkflowTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// DEPRECATE: use "workflows" instead.
        /// </summary>
        public WorkflowTemplateQuery SelectChanges(WorkflowQuery query)
        {
            query.FieldName = "changes";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public WorkflowTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public WorkflowTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Phases of the workflow template.
        /// </summary>
        public WorkflowTemplateQuery SelectPhases(WorkflowTemplatePhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// Task template relations of the workflow template.
        /// </summary>
        public WorkflowTemplateQuery SelectTaskTemplateRelations(WorkflowTaskTemplateRelationQuery query)
        {
            query.FieldName = "taskTemplateRelations";
            return Select(query);
        }

        /// <summary>
        /// Workflows of the workflow template.
        /// </summary>
        public WorkflowTemplateQuery SelectWorkflows(WorkflowQuery query)
        {
            query.FieldName = "workflows";
            return Select(query);
        }
    }
}
