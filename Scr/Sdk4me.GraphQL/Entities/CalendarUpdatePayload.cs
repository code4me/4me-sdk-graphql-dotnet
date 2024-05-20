using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/calendarupdatepayload/">CalendarUpdatePayload</see> object.
    /// </summary>
    public class CalendarUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("calendar"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }
    }
}
