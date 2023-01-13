namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/invoicecreatepayload/">InvoiceCreatePayload</see> object.
    /// </summary>
    public class InvoiceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("invoice"), Sdk4meField(true)]
        public Invoice? Invoice { get; internal set; }
    }
}
