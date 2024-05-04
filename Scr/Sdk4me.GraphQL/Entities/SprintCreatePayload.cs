using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/sprintcreatepayload/">SprintCreatePayload</see> object.
    /// </summary>
    public class SprintCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("sprint"), Sdk4meField(true)]
        public Sprint? Sprint { get; internal set; }
    }
}
