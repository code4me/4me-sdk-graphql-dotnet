namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new time entry.
    /// </summary>
    internal class TimeEntryCreateMutation : Mutation<TimeEntryCreatePayload, TimeEntryCreateInput>
    {
        /// <summary>
        /// Initialize an new TimeEntryCreate mutation instance.
        /// </summary>
        internal TimeEntryCreateMutation(TimeEntryCreateInput data)
            : base("timeEntryCreate", "TimeEntryCreateInput!", data, new HashSet<IQuery>() { new TimeEntryQuery() { FieldName = "timeEntry", IsConnection = false }.Select("*") })
        {
        }
    }
}
