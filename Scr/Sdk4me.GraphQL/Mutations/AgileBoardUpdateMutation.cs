namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing agile board.
    /// </summary>
    internal class AgileBoardUpdateMutation : Mutation<AgileBoardUpdatePayload, AgileBoardUpdateInput>
    {
        /// <summary>
        /// Initialize an new AgileBoardUpdate mutation instance.
        /// </summary>
        internal AgileBoardUpdateMutation(AgileBoardUpdateInput data)
            : base("agileBoardUpdate", "AgileBoardUpdateInput!", data, new HashSet<IQuery>() { new AgileBoardQuery() { FieldName = "agileBoard", IsConnection = false }.Select("*") })
        {
        }
    }
}
