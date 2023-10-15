namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new team.
    /// </summary>
    internal class TeamCreateMutation : Mutation<TeamCreatePayload, TeamCreateInput>
    {
        /// <summary>
        /// Initialize an new TeamCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal TeamCreateMutation(TeamCreateInput data, TeamQuery query)
            : base("teamCreate", "TeamCreateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() {query};
        }
    }
}
