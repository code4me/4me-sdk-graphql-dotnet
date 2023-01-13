namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project task template.
    /// </summary>
    internal class ProjectTaskTemplateCreateMutation : Mutation<ProjectTaskTemplateCreatePayload, ProjectTaskTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskTemplateCreate mutation instance.
        /// </summary>
        internal ProjectTaskTemplateCreateMutation(ProjectTaskTemplateCreateInput data)
            : base("projectTaskTemplateCreate", "ProjectTaskTemplateCreateInput!", data, new HashSet<IQuery>() { new ProjectTaskTemplateQuery() { FieldName = "projectTaskTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
