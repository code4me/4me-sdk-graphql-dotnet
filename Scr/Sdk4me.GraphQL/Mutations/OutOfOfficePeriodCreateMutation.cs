namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new out of office period.
    /// </summary>
    internal class OutOfOfficePeriodCreateMutation : Mutation<OutOfOfficePeriodCreatePayload, OutOfOfficePeriodCreateInput>
    {
        /// <summary>
        /// Initialize an new OutOfOfficePeriodCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal OutOfOfficePeriodCreateMutation(OutOfOfficePeriodCreateInput data, OutOfOfficePeriodQuery query)
            : base("outOfOfficePeriodCreate", "OutOfOfficePeriodCreateInput!", data, GetQuery(query))
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
