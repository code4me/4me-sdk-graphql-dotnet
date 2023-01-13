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
        internal ReservationUpdateMutation(ReservationUpdateInput data)
            : base("reservationUpdate", "ReservationUpdateInput!", data, new HashSet<IQuery>() { new ReservationQuery() { FieldName = "reservation", IsConnection = false }.Select("*") })
        {
        }
    }
}
