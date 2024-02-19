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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SprintUpdateMutation(SprintUpdateInput data, SprintQuery query)
            : base("sprintUpdate", "SprintUpdateInput!", data, GetQuery(query))
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
