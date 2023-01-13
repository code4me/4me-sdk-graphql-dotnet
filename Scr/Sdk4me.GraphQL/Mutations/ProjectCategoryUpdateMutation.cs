namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project category.
    /// </summary>
    internal class ProjectCategoryUpdateMutation : Mutation<ProjectCategoryUpdatePayload, ProjectCategoryUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectCategoryUpdate mutation instance.
        /// </summary>
        internal ProjectCategoryUpdateMutation(ProjectCategoryUpdateInput data)
            : base("projectCategoryUpdate", "ProjectCategoryUpdateInput!", data, new HashSet<IQuery>() { new ProjectCategoryQuery() { FieldName = "projectCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
