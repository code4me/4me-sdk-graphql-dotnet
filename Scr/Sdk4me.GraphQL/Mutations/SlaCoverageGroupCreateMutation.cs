namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new SLA coverage group.
    /// </summary>
    internal class SlaCoverageGroupCreateMutation : Mutation<SlaCoverageGroupCreatePayload, SlaCoverageGroupCreateInput>
    {
        /// <summary>
        /// Initialize an new SlaCoverageGroupCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SlaCoverageGroupCreateMutation(SlaCoverageGroupCreateInput data, SlaCoverageGroupQuery query)
            : base("slaCoverageGroupCreate", "SlaCoverageGroupCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SlaCoverageGroupQuery query)
        {
            query.FieldName = "slaCoverageGroup";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
