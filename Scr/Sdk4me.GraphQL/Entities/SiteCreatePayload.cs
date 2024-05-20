using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/sitecreatepayload/">SiteCreatePayload</see> object.
    /// </summary>
    public class SiteCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("site"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Site? Site { get; internal set; }
    }
}
