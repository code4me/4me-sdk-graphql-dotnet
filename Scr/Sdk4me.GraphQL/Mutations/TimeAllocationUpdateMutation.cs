namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing time allocation.
    /// </summary>
    internal class TimeAllocationUpdateMutation : Mutation<TimeAllocationUpdatePayload, TimeAllocationUpdateInput>
    {
        /// <summary>
        /// Initialize an new TimeAllocationUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal TimeAllocationUpdateMutation(TimeAllocationUpdateInput data, TimeAllocationQuery query)
            : base("timeAllocationUpdate", "TimeAllocationUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
