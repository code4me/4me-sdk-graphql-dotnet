namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project risk level.
    /// </summary>
    internal class ProjectRiskLevelUpdateMutation : Mutation<ProjectRiskLevelUpdatePayload, ProjectRiskLevelUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectRiskLevelUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProjectRiskLevelUpdateMutation(ProjectRiskLevelUpdateInput data, ProjectRiskLevelQuery query)
            : base("projectRiskLevelUpdate", "ProjectRiskLevelUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectRiskLevelQuery query)
        {
            query.FieldName = "projectRiskLevel";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
