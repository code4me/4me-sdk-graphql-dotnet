using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/permissioninput/">PermissionInput</see> object.
    /// </summary>
    public class PermissionInput : PropertyChangeSet
    {
        private string accountId;
        private List<PermissionRole>? roles;

        /// <summary>
        /// Identifier of the account for which the person has permissions.
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId
        {
            get => accountId;
            set => accountId = Set("accountId", value);
        }

        /// <summary>
        /// Roles the person has within the account.
        /// </summary>
        [JsonProperty("roles")]
        public List<PermissionRole>? Roles
        {
            get => roles;
            set => roles = Set("roles", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInput"/> class without providing the required values.
        /// </summary>
        public PermissionInput()
        {
            accountId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInput"/> class.
        /// </summary>
        /// <param name="accountId">Identifier of the account for which the person has permissions.</param>
        public PermissionInput(string accountId)
        {
            this.accountId = Set("accountId", accountId);
        }
    }
}
