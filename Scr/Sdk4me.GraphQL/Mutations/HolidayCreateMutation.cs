namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new holiday.
    /// </summary>
    internal class HolidayCreateMutation : Mutation<HolidayCreatePayload, HolidayCreateInput>
    {
        /// <summary>
        /// Initialize an new HolidayCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The holiday response query.</param>
        internal HolidayCreateMutation(HolidayCreateInput data, HolidayQuery query)
            : base("holidayCreate", "HolidayCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The holiday response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(HolidayQuery query)
        {
            query.FieldName = "holiday";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
