namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project.
    /// </summary>
    internal class ProjectUpdateMutation : Mutation<ProjectUpdatePayload, ProjectUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectUpdate mutation instance.
        /// </summary>
        internal ProjectUpdateMutation(ProjectUpdateInput data)
            : base("projectUpdate", "ProjectUpdateInput!", data, new HashSet<IQuery>() { new ProjectQuery() { FieldName = "project", IsConnection = false }.Select("*") })
        {
        }
    }
}
