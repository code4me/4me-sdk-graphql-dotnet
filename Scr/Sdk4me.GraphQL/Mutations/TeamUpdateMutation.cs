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
        internal TeamUpdateMutation(TeamUpdateInput data)
            : base("teamUpdate", "TeamUpdateInput!", data, new HashSet<IQuery>() { new TeamQuery() { FieldName = "team", IsConnection = false }.Select("*") })
        {
        }
    }
}
