namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new out of office period.
    /// </summary>
    internal class OutOfOfficePeriodCreateMutation : Mutation<OutOfOfficePeriodCreatePayload, OutOfOfficePeriodCreateInput>
    {
        /// <summary>
        /// Initialize an new OutOfOfficePeriodCreate mutation instance.
        /// </summary>
        internal OutOfOfficePeriodCreateMutation(OutOfOfficePeriodCreateInput data)
            : base("outOfOfficePeriodCreate", "OutOfOfficePeriodCreateInput!", data, new HashSet<IQuery>() { new OutOfOfficePeriodQuery() { FieldName = "outOfOfficePeriod", IsConnection = false }.Select("*") })
        {
        }
    }
}
