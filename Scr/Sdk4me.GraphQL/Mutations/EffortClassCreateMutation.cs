namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new effort class.
    /// </summary>
    internal class EffortClassCreateMutation : Mutation<EffortClassCreatePayload, EffortClassCreateInput>
    {
        /// <summary>
        /// Initialize an new EffortClassCreate mutation instance.
        /// </summary>
        internal EffortClassCreateMutation(EffortClassCreateInput data)
            : base("effortClassCreate", "EffortClassCreateInput!", data, new HashSet<IQuery>() { new EffortClassQuery() { FieldName = "effortClass", IsConnection = false }.Select("*") })
        {
        }
    }
}
