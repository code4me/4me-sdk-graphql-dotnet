namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing reservation.
    /// </summary>
    internal class ReservationUpdateMutation : Mutation<ReservationUpdatePayload, ReservationUpdateInput>
    {
        /// <summary>
        /// Initialize an new ReservationUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal ReservationUpdateMutation(ReservationUpdateInput data, ReservationQuery query)
            : base("reservationUpdate", "ReservationUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReservationQuery query)
        {
            query.FieldName = "reservation";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
