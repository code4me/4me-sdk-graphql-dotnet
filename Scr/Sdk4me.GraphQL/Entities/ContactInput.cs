namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/contactinput/">ContactInput</see> object.
    /// </summary>
    public class ContactInput : PropertyChangeSet
    {
        private string? id;
        private bool? integration;
        private ContactLabel? label;
        private ContactProtocol? protocol;
        private string? uri;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Can be set to <c>true</c> using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration")]
        public bool? Integration
        {
            get => integration;
            set => integration = Set("integration", value);
        }

        /// <summary>
        /// <br>The Label of the contact details. Valid values are:</br>
        /// <br>• <c>fax</c>: only for <c>telephone</c></br>
        /// <br>• <c>general</c>: only for organization <c>telephone</c>, <c>email</c> and <c>website</c></br>
        /// <br>• <c>home</c>: only for person <c>telephone</c></br>
        /// <br>• <c>mobile</c>: only for person <c>telephone</c></br>
        /// <br>• <c>personal</c>: only for person <c>email</c> and <c>website</c></br>
        /// <br>• <c>service_desk</c>: only for organization <c>telephone</c>, <c>email</c> and <c>website</c></br>
        /// <br>• <c>service_desk_fax</c>: only for organization <c>telephone</c></br>
        /// <br>• <c>work</c>: only for organization <c>telephone</c>, and for person <c>telephone</c>, <c>email</c> and <c>website</c></br>
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
    }
}
