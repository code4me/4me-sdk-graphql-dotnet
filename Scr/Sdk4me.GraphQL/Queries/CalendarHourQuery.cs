namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="CalendarHour">CalendarHour</see> query.
    /// </summary>
    public class CalendarHourQuery : Query<CalendarHourQuery, CalendarHourField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new calendar hour query instance.
        /// </summary>
        public CalendarHourQuery()
            : base("", typeof(CalendarHour), true)
        {
        }
    }
}
