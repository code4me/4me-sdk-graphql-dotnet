using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appinstancecreatepayload/">AppInstanceCreatePayload</see> object.
    /// </summary>
    public class AppInstanceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appInstance"), Sdk4meField(IsDefaultQueryProperty = true)]
        public AppInstance? AppInstance { get; internal set; }
    }
}
