using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/firstlinesupportagreementupdatepayload/">FirstLineSupportAgreementUpdatePayload</see> object.
    /// </summary>
    public class FirstLineSupportAgreementUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("firstLineSupportAgreement"), Sdk4meField(true)]
        public FirstLineSupportAgreement? FirstLineSupportAgreement { get; internal set; }
    }
}
