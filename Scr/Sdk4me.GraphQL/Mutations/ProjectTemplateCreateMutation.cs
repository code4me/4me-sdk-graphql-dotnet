namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project template.
    /// </summary>
    internal class ProjectTemplateCreateMutation : Mutation<ProjectTemplateCreatePayload, ProjectTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTemplateCreate mutation instance.
        /// </summary>
        internal ProjectTemplateCreateMutation(ProjectTemplateCreateInput data)
            : base("projectTemplateCreate", "ProjectTemplateCreateInput!", data, new HashSet<IQuery>() { new ProjectTemplateQuery() { FieldName = "projectTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
