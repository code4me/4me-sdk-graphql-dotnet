namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/contractcreatepayload/">ContractCreatePayload</see> object.
    /// </summary>
    public class ContractCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("contract"), Sdk4meField(true)]
        public Contract? Contract { get; internal set; }
    }
}
