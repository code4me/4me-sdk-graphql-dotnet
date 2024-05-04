using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservationofferingcreatepayload/">ReservationOfferingCreatePayload</see> object.
    /// </summary>
    public class ReservationOfferingCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservationOffering"), Sdk4meField(true)]
        public ReservationOffering? ReservationOffering { get; internal set; }
    }
}
