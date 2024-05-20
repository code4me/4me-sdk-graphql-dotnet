using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/servicelevelagreementcreatepayload/">ServiceLevelAgreementCreatePayload</see> object.
    /// </summary>
    public class ServiceLevelAgreementCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceLevelAgreement"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }
    }
}
