namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new calendar.
    /// </summary>
    internal class CalendarCreateMutation : Mutation<CalendarCreatePayload, CalendarCreateInput>
    {
        /// <summary>
        /// Initialize an new CalendarCreate mutation instance.
        /// </summary>
        internal CalendarCreateMutation(CalendarCreateInput data)
            : base("calendarCreate", "CalendarCreateInput!", data, new HashSet<IQuery>() { new CalendarQuery() { FieldName = "calendar", IsConnection = false }.Select("*") })
        {
        }
    }
}
