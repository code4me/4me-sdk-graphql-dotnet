using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/firstlinesupportagreementcreatepayload/">FirstLineSupportAgreementCreatePayload</see> object.
    /// </summary>
    public class FirstLineSupportAgreementCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("firstLineSupportAgreement"), Sdk4meField(IsDefaultQueryProperty = true)]
        public FirstLineSupportAgreement? FirstLineSupportAgreement { get; internal set; }
    }
}
