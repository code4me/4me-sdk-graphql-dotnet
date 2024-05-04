using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing calendar.
    /// </summary>
    internal class CalendarUpdateMutation : Mutation<CalendarUpdatePayload, CalendarUpdateInput>
    {
        /// <summary>
        /// Initialize an new CalendarUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The calendar response query.</param>
        internal CalendarUpdateMutation(CalendarUpdateInput data, CalendarQuery query)
            : base("calendarUpdate", "CalendarUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The calendar response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
