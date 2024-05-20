using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeentrycreatepayload/">TimeEntryCreatePayload</see> object.
    /// </summary>
    public class TimeEntryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeEntry"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TimeEntry? TimeEntry { get; internal set; }
    }
}
