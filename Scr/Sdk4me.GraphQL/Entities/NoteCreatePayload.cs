using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/notecreatepayload/">NoteCreatePayload</see> object.
    /// </summary>
    public class NoteCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("note"), Sdk4meField(true)]
        public Note? Note { get; internal set; }
    }
}
