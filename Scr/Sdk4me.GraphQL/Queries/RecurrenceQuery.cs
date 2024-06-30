namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Recurrence">Recurrence</see> query.
    /// </summary>
    public class RecurrenceQuery : Query<RecurrenceQuery, RecurrenceField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new recurrence query instance.
        /// </summary>
        public RecurrenceQuery()
            : base("", typeof(Recurrence), false)
        {
        }

        /// <summary>
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RecurrenceQuery SelectCalendar(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
