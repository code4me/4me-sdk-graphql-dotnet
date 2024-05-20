using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/holidaycreatepayload/">HolidayCreatePayload</see> object.
    /// </summary>
    public class HolidayCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("holiday"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Holiday? Holiday { get; internal set; }
    }
}
