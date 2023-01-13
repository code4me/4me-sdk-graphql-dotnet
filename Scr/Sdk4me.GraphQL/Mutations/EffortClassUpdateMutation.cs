namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing effort class.
    /// </summary>
    internal class EffortClassUpdateMutation : Mutation<EffortClassUpdatePayload, EffortClassUpdateInput>
    {
        /// <summary>
        /// Initialize an new EffortClassUpdate mutation instance.
        /// </summary>
        internal EffortClassUpdateMutation(EffortClassUpdateInput data)
            : base("effortClassUpdate", "EffortClassUpdateInput!", data, new HashSet<IQuery>() { new EffortClassQuery() { FieldName = "effortClass", IsConnection = false }.Select("*") })
        {
        }
    }
}
