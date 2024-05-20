using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/invoiceupdatepayload/">InvoiceUpdatePayload</see> object.
    /// </summary>
    public class InvoiceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("invoice"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Invoice? Invoice { get; internal set; }
    }
}
