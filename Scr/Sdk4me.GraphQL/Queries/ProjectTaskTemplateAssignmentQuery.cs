namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateAssignment">ProjectTaskTemplateAssignment</see> query.
    /// </summary>
    public class ProjectTaskTemplateAssignmentQuery : Query<ProjectTaskTemplateAssignmentQuery, ProjectTaskTemplateAssignmentField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project task template assignment query instance.
        /// </summary>
        public ProjectTaskTemplateAssignmentQuery()
            : base("", typeof(ProjectTaskTemplateAssignment), true)
        {
        }

        /// <summary>
        /// The person who is selected as the assignee for the project task template assignment.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskTemplateAssignmentQuery SelectAssignee(PersonQuery query)
        {
            query.FieldName = "assignee";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
