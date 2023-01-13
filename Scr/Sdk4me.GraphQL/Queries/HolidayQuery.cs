namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Holiday records.
    /// </summary>
    public class HolidayQuery : Query<HolidayQuery, HolidayField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new holiday query instance.
        /// </summary>
        public HolidayQuery()
            : base("holidays", typeof(Holiday), true)
        {
        }

        /// <summary>
        /// Calendars of the holiday.
        /// </summary>
        public HolidayQuery SelectCalendars(CalendarQuery query)
        {
            query.FieldName = "calendars";
            return Select(query);
        }
    }
}
