namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateRelation">ProjectTaskTemplateRelation</see> query.
    /// </summary>
    public class ProjectTaskTemplateRelationQuery : Query<ProjectTaskTemplateRelationQuery, ProjectTaskTemplateRelationField, DefaultView, DefaultFilter, DefaultOrderField>
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
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskTemplateRelationQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// The phase of the project template that the project task template is a part of.
        /// </summary>
        /// <param name="query">The project template phase query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskTemplateRelationQuery SelectPhase(ProjectTemplatePhaseQuery query)
        {
            query.FieldName = "phase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The project task template that is related to the project template.
        /// </summary>
        /// <param name="query">The project task template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskTemplateRelationQuery SelectTaskTemplate(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "taskTemplate";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
