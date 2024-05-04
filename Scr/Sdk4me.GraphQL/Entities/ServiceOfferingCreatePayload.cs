﻿using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceofferingcreatepayload/">ServiceOfferingCreatePayload</see> object.
    /// </summary>
    public class ServiceOfferingCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceOffering"), Sdk4meField(true)]
        public ServiceOffering? ServiceOffering { get; internal set; }
    }
}
