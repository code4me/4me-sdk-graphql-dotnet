namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/contactinput/">ContactInput</see> object.
    /// </summary>
    public class ContactInput : PropertyChangeSet
    {
        private string? id;
        private ContactLabel? label;
        private ContactProtocol? protocol;
        private string? uri;
        private bool? integration;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be `null`.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The Label of the contact details.
        /// </summary>
        [JsonProperty("label")]
        public ContactLabel? Label
        {
            get => label;
            set => label = Set("label", value);
        }

        /// <summary>
        /// The protocol of the contact details.
        /// </summary>
        [JsonProperty("protocol")]
        public ContactProtocol? Protocol
        {
            get => protocol;
            set => protocol = Set("protocol", value);
        }

        /// <summary>
        /// The telephone number, email address, etc.
        /// </summary>
        [JsonProperty("uri")]
        public string? Uri
        {
            get => uri;
            set => uri = Set("uri", value);
        }

        /// <summary>
        /// Can be set to `true` using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration")]
        public bool? Integration
        {
            get => integration;
            set => integration = Set("integration", value);
        }
    }
}
