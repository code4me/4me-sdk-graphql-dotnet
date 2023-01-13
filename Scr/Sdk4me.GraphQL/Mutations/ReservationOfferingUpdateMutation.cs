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
        internal ReservationOfferingUpdateMutation(ReservationOfferingUpdateInput data)
            : base("reservationOfferingUpdate", "ReservationOfferingUpdateInput!", data, new HashSet<IQuery>() { new ReservationOfferingQuery() { FieldName = "reservationOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
