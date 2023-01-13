namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shorturlcreatepayload/">ShortUrlCreatePayload</see> object.
    /// </summary>
    public class ShortUrlCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shortUrl"), Sdk4meField(true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}
