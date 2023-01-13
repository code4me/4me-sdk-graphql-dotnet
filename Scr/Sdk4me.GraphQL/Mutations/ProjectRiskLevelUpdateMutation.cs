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
        internal ProjectRiskLevelUpdateMutation(ProjectRiskLevelUpdateInput data)
            : base("projectRiskLevelUpdate", "ProjectRiskLevelUpdateInput!", data, new HashSet<IQuery>() { new ProjectRiskLevelQuery() { FieldName = "projectRiskLevel", IsConnection = false }.Select("*") })
        {
        }
    }
}
