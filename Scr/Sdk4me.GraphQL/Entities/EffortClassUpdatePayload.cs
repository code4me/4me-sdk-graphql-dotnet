using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclassupdatepayload/">EffortClassUpdatePayload</see> object.
    /// </summary>
    public class EffortClassUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("effortClass"), Sdk4meField(IsDefaultQueryProperty = true)]
        public EffortClass? EffortClass { get; internal set; }
    }
}
