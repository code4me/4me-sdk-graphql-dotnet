namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing sprint.
    /// </summary>
    internal class SprintUpdateMutation : Mutation<SprintUpdatePayload, SprintUpdateInput>
    {
        /// <summary>
        /// Initialize an new SprintUpdate mutation instance.
        /// </summary>
        internal SprintUpdateMutation(SprintUpdateInput data)
            : base("sprintUpdate", "SprintUpdateInput!", data, new HashSet<IQuery>() { new SprintQuery() { FieldName = "sprint", IsConnection = false }.Select("*") })
        {
        }
    }
}
