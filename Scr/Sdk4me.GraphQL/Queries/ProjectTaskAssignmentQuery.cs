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

        /// <summary>
        /// The person who is selected as the assignee for the assignment.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskAssignmentQuery SelectAssignee(PersonQuery query)
        {
            query.FieldName = "assignee";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
