using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/attachmentinput/">AttachmentInput</see> object.
    /// </summary>
    public class AttachmentInput : PropertyChangeSet
    {
        private bool? inline;
        private string key;
        private long? size;

        /// <summary>
        /// Whether the attachment is an inline image.
        /// </summary>
        [JsonProperty("inline")]
        public bool? Inline
        {
            get => inline;
            set => inline = Set("inline", value);
        }

        /// <summary>
        /// The key obtained from the attachment upload response.
        /// </summary>
        [JsonProperty("key")]
        public string Key
        {
            get => key;
            set => key = Set("key", value);
        }

        /// <summary>
        /// The size of the attachment in bytes.
        /// </summary>
        [JsonProperty("size")]
        public long? Size
        {
            get => size;
            set => size = Set("size", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInput"/> class without providing the required values.
        /// </summary>
        public AttachmentInput()
        {
            key = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInput"/> class.
        /// </summary>
        /// <param name="key">The key obtained from the attachment upload response.</param>
        public AttachmentInput(string key)
        {
            this.key = Set("key", key);
        }
    }
}
