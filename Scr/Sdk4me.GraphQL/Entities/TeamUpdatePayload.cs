using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/teamupdatepayload/">TeamUpdatePayload</see> object.
    /// </summary>
    public class TeamUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("team"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Team? Team { get; internal set; }
    }
}
