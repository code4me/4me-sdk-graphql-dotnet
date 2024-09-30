using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/contact/">Contact</see> object.
    /// </summary>
    public class Contact : Node
    {
        /// <summary>
        /// Can be set to <c>true</c> using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? Integration { get; internal set; }

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
        [JsonProperty("label"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ContactLabel? Label { get; internal set; }

        /// <summary>
        /// The protocol of the contact details.
        /// </summary>
        [JsonProperty("protocol"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ContactProtocol? Protocol { get; internal set; }

        /// <summary>
        /// The telephone number, email address, etc.
        /// </summary>
        [JsonProperty("uri"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Uri { get; internal set; }

        /// <summary>
        /// Only for person <c>email</c>. Indicates whether the email address is verified.
        /// </summary>
        [JsonProperty("verified")]
        public bool? Verified { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
