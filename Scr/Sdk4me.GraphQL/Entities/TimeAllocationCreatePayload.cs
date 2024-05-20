using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeallocationcreatepayload/">TimeAllocationCreatePayload</see> object.
    /// </summary>
    public class TimeAllocationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeAllocation"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TimeAllocation? TimeAllocation { get; internal set; }
    }
}
