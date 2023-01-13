namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing calendar.
    /// </summary>
    internal class CalendarUpdateMutation : Mutation<CalendarUpdatePayload, CalendarUpdateInput>
    {
        /// <summary>
        /// Initialize an new CalendarUpdate mutation instance.
        /// </summary>
        internal CalendarUpdateMutation(CalendarUpdateInput data)
            : base("calendarUpdate", "CalendarUpdateInput!", data, new HashSet<IQuery>() { new CalendarQuery() { FieldName = "calendar", IsConnection = false }.Select("*") })
        {
        }
    }
}
