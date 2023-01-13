namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectTemplate records.
    /// </summary>
    public class ProjectTemplateQuery : Query<ProjectTemplateQuery, ProjectTemplateField, ProjectTemplateView, ProjectTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new project template query instance.
        /// </summary>
        public ProjectTemplateQuery()
            : base("projectTemplates", typeof(ProjectTemplate), true)
        {
        }

        /// <summary>
        /// Phases of the project template.
        /// </summary>
        public ProjectTemplateQuery SelectPhases(ProjectTemplatePhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// Task template relations of the project template.
        /// </summary>
        public ProjectTemplateQuery SelectTaskTemplateRelations(ProjectTaskTemplateRelationQuery query)
        {
            query.FieldName = "taskTemplateRelations";
            return Select(query);
        }
    }
}
