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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SprintCreateMutation(SprintCreateInput data, SprintQuery query)
            : base("sprintCreate", "SprintCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SprintQuery query)
        {
            query.FieldName = "sprint";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
