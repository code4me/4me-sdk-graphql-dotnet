namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasTimeEntries">HasTimeEntries</see> query.
    /// </summary>
    public class HasTimeEntriesQuery : Query<HasTimeEntriesQuery, HasTimeEntriesField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has time entries query instance.
        /// </summary>
        public HasTimeEntriesQuery()
            : base("", typeof(HasTimeEntries), false)
        {
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public HasTimeEntriesQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }
    }
}
