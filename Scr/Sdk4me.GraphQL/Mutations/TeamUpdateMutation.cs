namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing team.
    /// </summary>
    internal class TeamUpdateMutation : Mutation<TeamUpdatePayload, TeamUpdateInput>
    {
        /// <summary>
        /// Initialize an new TeamUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TeamUpdateMutation(TeamUpdateInput data, TeamQuery query)
            : base("teamUpdate", "TeamUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
