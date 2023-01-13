namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project category.
    /// </summary>
    internal class ProjectCategoryCreateMutation : Mutation<ProjectCategoryCreatePayload, ProjectCategoryCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectCategoryCreate mutation instance.
        /// </summary>
        internal ProjectCategoryCreateMutation(ProjectCategoryCreateInput data)
            : base("projectCategoryCreate", "ProjectCategoryCreateInput!", data, new HashSet<IQuery>() { new ProjectCategoryQuery() { FieldName = "projectCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
