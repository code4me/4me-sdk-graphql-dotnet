namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservationcreatepayload/">ReservationCreatePayload</see> object.
    /// </summary>
    public class ReservationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservation"), Sdk4meField(true)]
        public Reservation? Reservation { get; internal set; }
    }
}
