namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing time entry.
    /// </summary>
    internal class TimeEntryUpdateMutation : Mutation<TimeEntryUpdatePayload, TimeEntryUpdateInput>
    {
        /// <summary>
        /// Initialize an new TimeEntryUpdate mutation instance.
        /// </summary>
        internal TimeEntryUpdateMutation(TimeEntryUpdateInput data)
            : base("timeEntryUpdate", "TimeEntryUpdateInput!", data, new HashSet<IQuery>() { new TimeEntryQuery() { FieldName = "timeEntry", IsConnection = false }.Select("*") })
        {
        }
    }
}
