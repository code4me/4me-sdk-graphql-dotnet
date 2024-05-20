using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlemailinput/">ShortUrlEmailInput</see> object.
    /// </summary>
    public class ShortUrlEmailInput : PropertyChangeSet
    {
        private string body;
        private string subject;
        private string to;

        /// <summary>
        /// Body of the email.
        /// </summary>
        [JsonProperty("body"), Sdk4meField(IsRequiredForMutation = true)]
        public string Body
        {
            get => body;
            set => body = Set("body", value);
        }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(IsRequiredForMutation = true)]
        public string Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Email address of the recipient of the email.
        /// </summary>
        [JsonProperty("to"), Sdk4meField(IsRequiredForMutation = true)]
        public string To
        {
            get => to;
            set => to = Set("to", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlEmailInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlEmailInput()
        {
            body = string.Empty;
            subject = string.Empty;
            to = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlEmailInput"/> class.
        /// </summary>
        /// <param name="body">Body of the email.</param>
        /// <param name="subject">Subject of the email.</param>
        /// <param name="to">Email address of the recipient of the email.</param>
        public ShortUrlEmailInput(string body, string subject, string to)
        {
            this.body = Set("body", body);
            this.subject = Set("subject", subject);
            this.to = Set("to", to);
        }
    }
}
