using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/pdfdesignupdatepayload/">PdfDesignUpdatePayload</see> object.
    /// </summary>
    public class PdfDesignUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("pdfDesign"), Sdk4meField(true)]
        public PdfDesign? PdfDesign { get; internal set; }
    }
}
