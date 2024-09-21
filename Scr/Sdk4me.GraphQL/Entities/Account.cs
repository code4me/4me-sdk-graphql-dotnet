using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/account/">Account</see> object.
    /// </summary>
    public class Account : Node
    {
        /// <summary>
        /// Indicates whether the account is disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The display name of the account.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The organization for which the account was prepared.
        /// </summary>
        [JsonProperty("organization")]
        public Organization? Organization { get; internal set; }

        /// <summary>
        /// The web address that is used to access the account.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
