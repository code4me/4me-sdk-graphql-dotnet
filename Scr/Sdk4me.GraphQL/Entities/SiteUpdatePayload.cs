namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/siteupdatepayload/">SiteUpdatePayload</see> object.
    /// </summary>
    public class SiteUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("site"), Sdk4meField(true)]
        public Site? Site { get; internal set; }
    }
}
