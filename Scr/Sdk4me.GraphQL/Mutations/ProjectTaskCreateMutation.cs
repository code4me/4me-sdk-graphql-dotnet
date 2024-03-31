namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project task.
    /// </summary>
    internal class ProjectTaskCreateMutation : Mutation<ProjectTaskCreatePayload, ProjectTaskCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProjectTaskCreateMutation(ProjectTaskCreateInput data, ProjectTaskQuery query)
            : base("projectTaskCreate", "ProjectTaskCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTaskQuery query)
        {
            query.FieldName = "projectTask";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
