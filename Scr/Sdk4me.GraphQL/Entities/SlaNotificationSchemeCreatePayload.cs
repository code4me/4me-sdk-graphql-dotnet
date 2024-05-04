using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/slanotificationschemecreatepayload/">SlaNotificationSchemeCreatePayload</see> object.
    /// </summary>
    public class SlaNotificationSchemeCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaNotificationScheme"), Sdk4meField(true)]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }
    }
}
