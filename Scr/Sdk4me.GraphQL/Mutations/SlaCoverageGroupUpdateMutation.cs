namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing SLA coverage group.
    /// </summary>
    internal class SlaCoverageGroupUpdateMutation : Mutation<SlaCoverageGroupUpdatePayload, SlaCoverageGroupUpdateInput>
    {
        /// <summary>
        /// Initialize an new SlaCoverageGroupUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The sla coverage group response query.</param>
        internal SlaCoverageGroupUpdateMutation(SlaCoverageGroupUpdateInput data, SlaCoverageGroupQuery query)
            : base("slaCoverageGroupUpdate", "SlaCoverageGroupUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The sla coverage group response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SlaCoverageGroupQuery query)
        {
            query.FieldName = "slaCoverageGroup";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
