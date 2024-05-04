using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/agileboardupdatepayload/">AgileBoardUpdatePayload</see> object.
    /// </summary>
    public class AgileBoardUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("agileBoard"), Sdk4meField(true)]
        public AgileBoard? AgileBoard { get; internal set; }
    }
}
