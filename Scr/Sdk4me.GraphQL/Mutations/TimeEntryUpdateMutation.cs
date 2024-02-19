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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TimeEntryUpdateMutation(TimeEntryUpdateInput data, TimeEntryQuery query)
            : base("timeEntryUpdate", "TimeEntryUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimeEntryQuery query)
        {
            query.FieldName = "timeEntry";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
