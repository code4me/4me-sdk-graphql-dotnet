namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskAssignment">ProjectTaskAssignment</see> query.
    /// </summary>
    public class ProjectTaskAssignmentQuery : Query<ProjectTaskAssignmentQuery, ProjectTaskAssignmentField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project task assignment query instance.
        /// </summary>
        public ProjectTaskAssignmentQuery()
            : base("", typeof(ProjectTaskAssignment), true)
        {
        }
    }
}
