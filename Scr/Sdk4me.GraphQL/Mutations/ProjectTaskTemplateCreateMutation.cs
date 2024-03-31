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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProjectTaskTemplateCreateMutation(ProjectTaskTemplateCreateInput data, ProjectTaskTemplateQuery query)
            : base("projectTaskTemplateCreate", "ProjectTaskTemplateCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "projectTaskTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
