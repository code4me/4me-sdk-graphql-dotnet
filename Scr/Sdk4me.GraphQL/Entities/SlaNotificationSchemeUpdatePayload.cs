using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/slanotificationschemeupdatepayload/">SlaNotificationSchemeUpdatePayload</see> object.
    /// </summary>
    public class SlaNotificationSchemeUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaNotificationScheme"), Sdk4meField(IsDefaultQueryProperty = true)]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }
    }
}
