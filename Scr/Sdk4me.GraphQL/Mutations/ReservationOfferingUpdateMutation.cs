namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing reservation offering.
    /// </summary>
    internal class ReservationOfferingUpdateMutation : Mutation<ReservationOfferingUpdatePayload, ReservationOfferingUpdateInput>
    {
        /// <summary>
        /// Initialize an new ReservationOfferingUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The reservation offering response query.</param>
        internal ReservationOfferingUpdateMutation(ReservationOfferingUpdateInput data, ReservationOfferingQuery query)
            : base("reservationOfferingUpdate", "ReservationOfferingUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The reservation offering response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReservationOfferingQuery query)
        {
            query.FieldName = "reservationOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
