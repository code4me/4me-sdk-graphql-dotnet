using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/contractupdatepayload/">ContractUpdatePayload</see> object.
    /// </summary>
    public class ContractUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("contract"), Sdk4meField(true)]
        public Contract? Contract { get; internal set; }
    }
}
