namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeentryupdatepayload/">TimeEntryUpdatePayload</see> object.
    /// </summary>
    public class TimeEntryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeEntry"), Sdk4meField(true)]
        public TimeEntry? TimeEntry { get; internal set; }
    }
}
