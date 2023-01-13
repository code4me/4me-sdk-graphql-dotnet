namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project task.
    /// </summary>
    internal class ProjectTaskUpdateMutation : Mutation<ProjectTaskUpdatePayload, ProjectTaskUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskUpdate mutation instance.
        /// </summary>
        internal ProjectTaskUpdateMutation(ProjectTaskUpdateInput data)
            : base("projectTaskUpdate", "ProjectTaskUpdateInput!", data, new HashSet<IQuery>() { new ProjectTaskQuery() { FieldName = "projectTask", IsConnection = false }.Select("*") })
        {
        }
    }
}
