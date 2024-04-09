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
        /// Initialize a new calendar query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the calendar.</param>
        public CalendarQuery(string id)
            : base("Calendar", id, typeof(Calendar), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CalendarQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        /// <param name="query">The calendar hour query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CalendarQuery SelectCalendarHours(CalendarHourQuery query)
        {
            query.FieldName = "calendarHours";
            return Select(query);
        }

        /// <summary>
        /// Holidays of the calendar.
        /// </summary>
        /// <param name="query">The holiday query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CalendarQuery SelectHolidays(HolidayQuery query)
        {
            query.FieldName = "holidays";
            return Select(query);
        }
    }
}
