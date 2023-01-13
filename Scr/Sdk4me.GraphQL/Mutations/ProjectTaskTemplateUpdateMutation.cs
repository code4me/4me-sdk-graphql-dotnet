namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project task template.
    /// </summary>
    internal class ProjectTaskTemplateUpdateMutation : Mutation<ProjectTaskTemplateUpdatePayload, ProjectTaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskTemplateUpdate mutation instance.
        /// </summary>
        internal ProjectTaskTemplateUpdateMutation(ProjectTaskTemplateUpdateInput data)
            : base("projectTaskTemplateUpdate", "ProjectTaskTemplateUpdateInput!", data, new HashSet<IQuery>() { new ProjectTaskTemplateQuery() { FieldName = "projectTaskTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
