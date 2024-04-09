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
        /// <param name="data">The input data.</param>
        /// <param name="query">The project category response query.</param>
        internal ProjectCategoryCreateMutation(ProjectCategoryCreateInput data, ProjectCategoryQuery query)
            : base("projectCategoryCreate", "ProjectCategoryCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project category response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectCategoryQuery query)
        {
            query.FieldName = "projectCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
