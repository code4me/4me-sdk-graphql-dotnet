namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="RecurrenceTemplate">RecurrenceTemplate</see> query.
    /// </summary>
    public class RecurrenceTemplateQuery : Query<RecurrenceTemplateQuery, RecurrenceTemplateField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new recurrence template query instance.
        /// </summary>
        public RecurrenceTemplateQuery()
            : base("", typeof(RecurrenceTemplate), false)
        {
        }

        /// <summary>
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RecurrenceTemplateQuery SelectCalendar(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
