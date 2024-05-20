using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shorturlupdatepayload/">ShortUrlUpdatePayload</see> object.
    /// </summary>
    public class ShortUrlUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shortUrl"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}
