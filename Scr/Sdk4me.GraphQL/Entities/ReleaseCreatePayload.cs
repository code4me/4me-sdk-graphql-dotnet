using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/releasecreatepayload/">ReleaseCreatePayload</see> object.
    /// </summary>
    public class ReleaseCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("release"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Release? Release { get; internal set; }
    }
}
