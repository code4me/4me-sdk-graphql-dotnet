namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectPhase">ProjectPhase</see> query.
    /// </summary>
    public class ProjectPhaseQuery : Query<ProjectPhaseQuery, ProjectPhaseField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project phase query instance.
        /// </summary>
        public ProjectPhaseQuery()
            : base("", typeof(ProjectPhase), true)
        {
        }
    }
}
