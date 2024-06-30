namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Holiday records.
    /// </summary>
    public class HolidayQuery : Query<HolidayQuery, HolidayField, DefaultView, HolidayFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new holiday query instance.
        /// </summary>
        public HolidayQuery()
            : base("holidays", typeof(Holiday), true)
        {
        }

        /// <summary>
        /// Initialize a new holiday query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the holiday.</param>
        public HolidayQuery(string id)
            : base("Holiday", id, typeof(Holiday), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public HolidayQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendars of the holiday.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public HolidayQuery SelectCalendars(CalendarQuery query)
        {
            query.FieldName = "calendars";
            return Select(query);
        }
    }
}
