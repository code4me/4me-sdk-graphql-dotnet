namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project.
    /// </summary>
    internal class ProjectCreateMutation : Mutation<ProjectCreatePayload, ProjectCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectCreate mutation instance.
        /// </summary>
        internal ProjectCreateMutation(ProjectCreateInput data)
            : base("projectCreate", "ProjectCreateInput!", data, new HashSet<IQuery>() { new ProjectQuery() { FieldName = "project", IsConnection = false }.Select("*") })
        {
        }
    }
}
