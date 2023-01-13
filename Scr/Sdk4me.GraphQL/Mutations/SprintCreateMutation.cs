namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new sprint.
    /// </summary>
    internal class SprintCreateMutation : Mutation<SprintCreatePayload, SprintCreateInput>
    {
        /// <summary>
        /// Initialize an new SprintCreate mutation instance.
        /// </summary>
        internal SprintCreateMutation(SprintCreateInput data)
            : base("sprintCreate", "SprintCreateInput!", data, new HashSet<IQuery>() { new SprintQuery() { FieldName = "sprint", IsConnection = false }.Select("*") })
        {
        }
    }
}
