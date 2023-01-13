namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new holiday.
    /// </summary>
    internal class HolidayCreateMutation : Mutation<HolidayCreatePayload, HolidayCreateInput>
    {
        /// <summary>
        /// Initialize an new HolidayCreate mutation instance.
        /// </summary>
        internal HolidayCreateMutation(HolidayCreateInput data)
            : base("holidayCreate", "HolidayCreateInput!", data, new HashSet<IQuery>() { new HolidayQuery() { FieldName = "holiday", IsConnection = false }.Select("*") })
        {
        }
    }
}
