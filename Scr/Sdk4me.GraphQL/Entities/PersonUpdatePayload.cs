using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/personupdatepayload/">PersonUpdatePayload</see> object.
    /// </summary>
    public class PersonUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(true)]
        public Person? Person { get; internal set; }
    }
}
