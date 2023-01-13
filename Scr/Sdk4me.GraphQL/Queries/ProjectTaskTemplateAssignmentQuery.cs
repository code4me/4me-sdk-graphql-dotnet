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
    }
}
