namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new time allocation.
    /// </summary>
    internal class TimeAllocationCreateMutation : Mutation<TimeAllocationCreatePayload, TimeAllocationCreateInput>
    {
        /// <summary>
        /// Initialize an new TimeAllocationCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The time allocation response query.</param>
        internal TimeAllocationCreateMutation(TimeAllocationCreateInput data, TimeAllocationQuery query)
            : base("timeAllocationCreate", "TimeAllocationCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The time allocation response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
