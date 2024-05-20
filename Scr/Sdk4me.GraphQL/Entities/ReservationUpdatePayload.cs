﻿using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservationupdatepayload/">ReservationUpdatePayload</see> object.
    /// </summary>
    public class ReservationUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservation"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Reservation? Reservation { get; internal set; }
    }
}
