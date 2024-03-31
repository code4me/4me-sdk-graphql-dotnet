namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new reservation offering.
    /// </summary>
    internal class ReservationOfferingCreateMutation : Mutation<ReservationOfferingCreatePayload, ReservationOfferingCreateInput>
    {
        /// <summary>
        /// Initialize an new ReservationOfferingCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ReservationOfferingCreateMutation(ReservationOfferingCreateInput data, ReservationOfferingQuery query)
            : base("reservationOfferingCreate", "ReservationOfferingCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReservationOfferingQuery query)
        {
            query.FieldName = "reservationOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
