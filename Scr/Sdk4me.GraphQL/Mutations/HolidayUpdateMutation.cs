namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing holiday.
    /// </summary>
    internal class HolidayUpdateMutation : Mutation<HolidayUpdatePayload, HolidayUpdateInput>
    {
        /// <summary>
        /// Initialize an new HolidayUpdate mutation instance.
        /// </summary>
        internal HolidayUpdateMutation(HolidayUpdateInput data)
            : base("holidayUpdate", "HolidayUpdateInput!", data, new HashSet<IQuery>() { new HolidayQuery() { FieldName = "holiday", IsConnection = false }.Select("*") })
        {
        }
    }
}
