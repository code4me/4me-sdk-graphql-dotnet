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
        internal TimeAllocationUpdateMutation(TimeAllocationUpdateInput data)
            : base("timeAllocationUpdate", "TimeAllocationUpdateInput!", data, new HashSet<IQuery>() { new TimeAllocationQuery() { FieldName = "timeAllocation", IsConnection = false }.Select("*") })
        {
        }
    }
}
