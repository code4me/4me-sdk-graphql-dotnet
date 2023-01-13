namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/releaseupdatepayload/">ReleaseUpdatePayload</see> object.
    /// </summary>
    public class ReleaseUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("release"), Sdk4meField(true)]
        public Release? Release { get; internal set; }
    }
}
