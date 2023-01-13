namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing out of office period.
    /// </summary>
    internal class OutOfOfficePeriodUpdateMutation : Mutation<OutOfOfficePeriodUpdatePayload, OutOfOfficePeriodUpdateInput>
    {
        /// <summary>
        /// Initialize an new OutOfOfficePeriodUpdate mutation instance.
        /// </summary>
        internal OutOfOfficePeriodUpdateMutation(OutOfOfficePeriodUpdateInput data)
            : base("outOfOfficePeriodUpdate", "OutOfOfficePeriodUpdateInput!", data, new HashSet<IQuery>() { new OutOfOfficePeriodQuery() { FieldName = "outOfOfficePeriod", IsConnection = false }.Select("*") })
        {
        }
    }
}
