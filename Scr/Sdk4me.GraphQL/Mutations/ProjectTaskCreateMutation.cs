namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project task.
    /// </summary>
    internal class ProjectTaskCreateMutation : Mutation<ProjectTaskCreatePayload, ProjectTaskCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskCreate mutation instance.
        /// </summary>
        internal ProjectTaskCreateMutation(ProjectTaskCreateInput data)
            : base("projectTaskCreate", "ProjectTaskCreateInput!", data, new HashSet<IQuery>() { new ProjectTaskQuery() { FieldName = "projectTask", IsConnection = false }.Select("*") })
        {
        }
    }
}
