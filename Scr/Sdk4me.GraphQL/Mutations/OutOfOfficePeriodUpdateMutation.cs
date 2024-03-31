namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing out of office period.
    /// </summary>
    internal class OutOfOfficePeriodUpdateMutation : Mutation<OutOfOfficePeriodUpdatePayload, OutOfOfficePeriodUpdateInput>
    {
        /// <summary>
        /// Initialize an new OutOfOfficePeriodUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal OutOfOfficePeriodUpdateMutation(OutOfOfficePeriodUpdateInput data, OutOfOfficePeriodQuery query)
            : base("outOfOfficePeriodUpdate", "OutOfOfficePeriodUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(OutOfOfficePeriodQuery query)
        {
            query.FieldName = "outOfOfficePeriod";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
