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
    }
}
