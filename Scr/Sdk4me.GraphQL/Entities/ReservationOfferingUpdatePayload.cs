namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservationofferingupdatepayload/">ReservationOfferingUpdatePayload</see> object.
    /// </summary>
    public class ReservationOfferingUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservationOffering"), Sdk4meField(true)]
        public ReservationOffering? ReservationOffering { get; internal set; }
    }
}
