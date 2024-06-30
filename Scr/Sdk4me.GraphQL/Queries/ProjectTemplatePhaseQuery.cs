namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTemplatePhase">ProjectTemplatePhase</see> query.
    /// </summary>
    public class ProjectTemplatePhaseQuery : Query<ProjectTemplatePhaseQuery, ProjectTemplatePhaseField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project template phase query instance.
        /// </summary>
        public ProjectTemplatePhaseQuery()
            : base("", typeof(ProjectTemplatePhase), true)
        {
        }
    }
}
