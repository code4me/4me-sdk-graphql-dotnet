using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/sprintupdatepayload/">SprintUpdatePayload</see> object.
    /// </summary>
    public class SprintUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("sprint"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Sprint? Sprint { get; internal set; }
    }
}
