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
        /// <param name="data">The input data.</param>
        /// <param name="query">The project template response query.</param>
        internal ProjectTemplateUpdateMutation(ProjectTemplateUpdateInput data, ProjectTemplateQuery query)
            : base("projectTemplateUpdate", "ProjectTemplateUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project template response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTemplateQuery query)
        {
            query.FieldName = "projectTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
