﻿using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingpublishmutationpayload/">AppOfferingPublishMutationPayload</see> object.
    /// </summary>
    public class AppOfferingPublishMutationPayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOffering"), Sdk4meField(IsDefaultQueryProperty = true)]
        public AppOffering? AppOffering { get; internal set; }
    }
}
