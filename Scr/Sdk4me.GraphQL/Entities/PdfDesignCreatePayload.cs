namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/pdfdesigncreatepayload/">PdfDesignCreatePayload</see> object.
    /// </summary>
    public class PdfDesignCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("pdfDesign"), Sdk4meField(true)]
        public PdfDesign? PdfDesign { get; internal set; }
    }
}
