namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateRelation">ProjectTaskTemplateRelation</see> query.
    /// </summary>
    public class ProjectTaskTemplateRelationQuery : Query<ProjectTaskTemplateRelationQuery, ProjectTaskTemplateRelationField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project task template relation query instance.
        /// </summary>
        public ProjectTaskTemplateRelationQuery()
            : base("", typeof(ProjectTaskTemplateRelation), true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ProjectTaskTemplateRelationQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }
    }
}
