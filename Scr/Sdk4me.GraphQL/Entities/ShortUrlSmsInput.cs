using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlsmsinput/">ShortUrlSmsInput</see> object.
    /// </summary>
    public class ShortUrlSmsInput : PropertyChangeSet
    {
        private string? body;
        private string? tel;

        /// <summary>
        /// Text of the SMS message
        /// </summary>
        [JsonProperty("body")]
        public string? Body
        {
            get => body;
            set => body = Set("body", value);
        }

        /// <summary>
        /// Telephone number of the recipient of the SMS message
        /// </summary>
        [JsonProperty("tel")]
        public string? Tel
        {
            get => tel;
            set => tel = Set("tel", value);
        }
    }
}
