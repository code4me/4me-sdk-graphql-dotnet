namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/contact/">Contact</see> object.
    /// </summary>
    public class Contact : Node
    {
        /// <summary>
        /// Can be set to `true` using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration"), Sdk4meField(true)]
        public bool? Integration { get; internal set; }

        /// <summary>
        /// The Label of the contact details.
        /// </summary>
        [JsonProperty("label"), Sdk4meField(true)]
        public ContactLabel? Label { get; internal set; }

        /// <summary>
        /// The protocol of the contact details.
        /// </summary>
        [JsonProperty("protocol"), Sdk4meField(true)]
        public ContactProtocol? Protocol { get; internal set; }

        /// <summary>
        /// The telephone number, email address, etc.
        /// </summary>
        [JsonProperty("uri"), Sdk4meField(true)]
        public string? Uri { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
