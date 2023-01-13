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
    }
}
