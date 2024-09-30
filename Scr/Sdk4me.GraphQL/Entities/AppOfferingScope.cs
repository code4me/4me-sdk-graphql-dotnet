using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingscope/">AppOfferingScope</see> object.
    /// </summary>
    public class AppOfferingScope : Node
    {
        /// <summary>
        /// Actions this scope applies to.
        /// </summary>
        [JsonProperty("actions"), Sdk4meField(IsDefaultQueryProperty = true)]
        public List<string>? Actions { get; internal set; }

        /// <summary>
        /// Conditions for this scope.
        /// </summary>
        [JsonProperty("conditions")]
        public List<string>? Conditions { get; internal set; }

        /// <summary>
        /// Whether this scope allows or prevents access.
        /// </summary>
        [JsonProperty("effect")]
        public ScopeEffect? Effect { get; internal set; }

        /// <summary>
        /// Whether this scope is for the app's OAuth application using <see href="https://developer.xurrent.com/v1/oauth/client_credentials_grant/">client credentials</see> or <see href="https://developer.xurrent.com/v1/oauth/authorization_code_grant/">authorization code grant</see>.
        /// </summary>
        [JsonProperty("grantType")]
        public OauthApplicationGrantType? GrantType { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
