namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing holiday.
    /// </summary>
    internal class HolidayUpdateMutation : Mutation<HolidayUpdatePayload, HolidayUpdateInput>
    {
        /// <summary>
        /// Initialize an new HolidayUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal HolidayUpdateMutation(HolidayUpdateInput data, HolidayQuery query)
            : base("holidayUpdate", "HolidayUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(HolidayQuery query)
        {
            query.FieldName = "holiday";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
