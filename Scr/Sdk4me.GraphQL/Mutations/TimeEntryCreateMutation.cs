using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The time entry response query.</param>
        internal TimeEntryCreateMutation(TimeEntryCreateInput data, TimeEntryQuery query)
            : base("timeEntryCreate", "TimeEntryCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The time entry response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimeEntryQuery query)
        {
            query.FieldName = "timeEntry";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
