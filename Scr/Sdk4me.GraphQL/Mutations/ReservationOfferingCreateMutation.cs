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
        internal ReservationOfferingCreateMutation(ReservationOfferingCreateInput data)
            : base("reservationOfferingCreate", "ReservationOfferingCreateInput!", data, new HashSet<IQuery>() { new ReservationOfferingQuery() { FieldName = "reservationOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
