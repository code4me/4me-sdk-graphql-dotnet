namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new reservation.
    /// </summary>
    internal class ReservationCreateMutation : Mutation<ReservationCreatePayload, ReservationCreateInput>
    {
        /// <summary>
        /// Initialize an new ReservationCreate mutation instance.
        /// </summary>
        internal ReservationCreateMutation(ReservationCreateInput data)
            : base("reservationCreate", "ReservationCreateInput!", data, new HashSet<IQuery>() { new ReservationQuery() { FieldName = "reservation", IsConnection = false }.Select("*") })
        {
        }
    }
}
