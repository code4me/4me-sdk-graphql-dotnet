namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project template.
    /// </summary>
    internal class ProjectTemplateUpdateMutation : Mutation<ProjectTemplateUpdatePayload, ProjectTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTemplateUpdate mutation instance.
        /// </summary>
        internal ProjectTemplateUpdateMutation(ProjectTemplateUpdateInput data)
            : base("projectTemplateUpdate", "ProjectTemplateUpdateInput!", data, new HashSet<IQuery>() { new ProjectTemplateQuery() { FieldName = "projectTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
