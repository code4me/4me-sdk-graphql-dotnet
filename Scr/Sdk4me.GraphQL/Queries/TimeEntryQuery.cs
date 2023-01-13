namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimeEntry records.
    /// </summary>
    public class TimeEntryQuery : Query<TimeEntryQuery, TimeEntryField, TimeEntryView, TimeEntryOrderField>
    {
        /// <summary>
        /// Initialize a new time entry query instance.
        /// </summary>
        public TimeEntryQuery()
            : base("timeEntries", typeof(TimeEntry), true)
        {
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        public TimeEntryQuery SelectAssignment(HasTimeEntriesQuery query)
        {
            query.FieldName = "assignment";
            return Select(query);
        }
    }
}
