using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlemailinput/">ShortUrlEmailInput</see> object.
    /// </summary>
    public class ShortUrlEmailInput : PropertyChangeSet
    {
        private string? body;
        private string? subject;
        private string? to;

        /// <summary>
        /// Body of the email.
        /// </summary>
        [JsonProperty("body")]
        public string? Body
        {
            get => body;
            set => body = Set("body", value);
        }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Email address of the recipient of the email.
        /// </summary>
        [JsonProperty("to")]
        public string? To
        {
            get => to;
            set => to = Set("to", value);
        }
    }
}
