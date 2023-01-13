namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Calendar records.
    /// </summary>
    public class CalendarQuery : Query<CalendarQuery, CalendarField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new calendar query instance.
        /// </summary>
        public CalendarQuery()
            : base("calendars", typeof(Calendar), true)
        {
        }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        public CalendarQuery SelectCalendarHours(CalendarHourQuery query)
        {
            query.FieldName = "calendarHours";
            return Select(query);
        }

        /// <summary>
        /// Holidays of the calendar.
        /// </summary>
        public CalendarQuery SelectHolidays(HolidayQuery query)
        {
            query.FieldName = "holidays";
            return Select(query);
        }
    }
}
