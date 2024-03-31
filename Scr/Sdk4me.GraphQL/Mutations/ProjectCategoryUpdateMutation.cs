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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProjectCategoryUpdateMutation(ProjectCategoryUpdateInput data, ProjectCategoryQuery query)
            : base("projectCategoryUpdate", "ProjectCategoryUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectCategoryQuery query)
        {
            query.FieldName = "projectCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
