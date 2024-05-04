using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/teamcreatepayload/">TeamCreatePayload</see> object.
    /// </summary>
    public class TeamCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("team"), Sdk4meField(true)]
        public Team? Team { get; internal set; }
    }
}
