using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/calendarcreatepayload/">CalendarCreatePayload</see> object.
    /// </summary>
    public class CalendarCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("calendar"), Sdk4meField(true)]
        public Calendar? Calendar { get; internal set; }
    }
}
