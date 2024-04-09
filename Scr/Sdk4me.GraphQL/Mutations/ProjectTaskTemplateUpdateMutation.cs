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
        /// <param name="data">The input data.</param>
        /// <param name="query">The project task template response query.</param>
        internal ProjectTaskTemplateUpdateMutation(ProjectTaskTemplateUpdateInput data, ProjectTaskTemplateQuery query)
            : base("projectTaskTemplateUpdate", "ProjectTaskTemplateUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project task template response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "projectTaskTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
