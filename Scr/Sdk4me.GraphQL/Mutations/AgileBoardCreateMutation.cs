namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new agile board.
    /// </summary>
    internal class AgileBoardCreateMutation : Mutation<AgileBoardCreatePayload, AgileBoardCreateInput>
    {
        /// <summary>
        /// Initialize an new AgileBoardCreate mutation instance.
        /// </summary>
        internal AgileBoardCreateMutation(AgileBoardCreateInput data)
            : base("agileBoardCreate", "AgileBoardCreateInput!", data, new HashSet<IQuery>() { new AgileBoardQuery() { FieldName = "agileBoard", IsConnection = false }.Select("*") })
        {
        }
    }
}
