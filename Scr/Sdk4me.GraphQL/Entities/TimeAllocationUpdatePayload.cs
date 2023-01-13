namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeallocationupdatepayload/">TimeAllocationUpdatePayload</see> object.
    /// </summary>
    public class TimeAllocationUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeAllocation"), Sdk4meField(true)]
        public TimeAllocation? TimeAllocation { get; internal set; }
    }
}
