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
        internal TeamCreateMutation(TeamCreateInput data)
            : base("teamCreate", "TeamCreateInput!", data, new HashSet<IQuery>() { new TeamQuery() { FieldName = "team", IsConnection = false }.Select("*") })
        {
        }
    }
}
