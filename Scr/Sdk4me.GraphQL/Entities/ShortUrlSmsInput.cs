using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlsmsinput/">ShortUrlSmsInput</see> object.
    /// </summary>
    public class ShortUrlSmsInput : PropertyChangeSet
    {
        private string body;
        private string tel;

        /// <summary>
        /// Text of the SMS message
        /// </summary>
        [JsonProperty("body"), Sdk4meField(IsRequiredForMutation = true)]
        public string Body
        {
            get => body;
            set => body = Set("body", value);
        }

        /// <summary>
        /// Telephone number of the recipient of the SMS message
        /// </summary>
        [JsonProperty("tel"), Sdk4meField(IsRequiredForMutation = true)]
        public string Tel
        {
            get => tel;
            set => tel = Set("tel", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlSmsInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlSmsInput()
        {
            body = string.Empty;
            tel = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlSmsInput"/> class.
        /// </summary>
        /// <param name="body">Text of the SMS message</param>
        /// <param name="tel">Telephone number of the recipient of the SMS message</param>
        public ShortUrlSmsInput(string body, string tel)
        {
            this.body = Set("body", body);
            this.tel = Set("tel", tel);
        }
    }
}
