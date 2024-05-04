using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/skillpoolcreatepayload/">SkillPoolCreatePayload</see> object.
    /// </summary>
    public class SkillPoolCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("skillPool"), Sdk4meField(true)]
        public SkillPool? SkillPool { get; internal set; }
    }
}
