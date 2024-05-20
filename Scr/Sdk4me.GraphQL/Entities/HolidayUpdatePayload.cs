using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/holidayupdatepayload/">HolidayUpdatePayload</see> object.
    /// </summary>
    public class HolidayUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("holiday"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Holiday? Holiday { get; internal set; }
    }
}
