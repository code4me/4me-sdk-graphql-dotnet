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

        /// <summary>
        /// The phase of the project template that the project task template is a part of.
        /// </summary>
        public ProjectTaskTemplateRelationQuery SelectPhase(ProjectTemplatePhaseQuery query)
        {
            query.FieldName = "phase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The project task template that is related to the project template.
        /// </summary>
        public ProjectTaskTemplateRelationQuery SelectTaskTemplate(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "taskTemplate";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
