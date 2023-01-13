namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/agileboardcreatepayload/">AgileBoardCreatePayload</see> object.
    /// </summary>
    public class AgileBoardCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("agileBoard"), Sdk4meField(true)]
        public AgileBoard? AgileBoard { get; internal set; }
    }
}
