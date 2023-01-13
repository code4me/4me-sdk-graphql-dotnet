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
        internal TimeAllocationCreateMutation(TimeAllocationCreateInput data)
            : base("timeAllocationCreate", "TimeAllocationCreateInput!", data, new HashSet<IQuery>() { new TimeAllocationQuery() { FieldName = "timeAllocation", IsConnection = false }.Select("*") })
        {
        }
    }
}
