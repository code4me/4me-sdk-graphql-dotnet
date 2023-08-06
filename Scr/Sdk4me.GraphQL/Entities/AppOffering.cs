namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appoffering/">AppOffering</see> object.
    /// </summary>
    public class AppOffering : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("appInstances")]
        internal NodeCollection<AppInstance>? AppInstancesCollection { get; set; }

        /// <summary>
        /// Instances of this app.
        /// </summary>
        public DataList<AppInstance>? AppInstances
        {
            get => AppInstancesCollection?.Data;
        }

        [JsonProperty("automationRules")]
        internal NodeCollection<AppOfferingAutomationRule>? AutomationRulesCollection { get; set; }

        /// <summary>
        /// Automation rules of this app offering.
        /// </summary>
        public DataList<AppOfferingAutomationRule>? AutomationRules
        {
            get => AutomationRulesCollection?.Data;
        }

        /// <summary>
        /// Compliance description of the app offering.
        /// </summary>
        [JsonProperty("compliance")]
        public string? Compliance { get; internal set; }

        [JsonProperty("complianceAttachments")]
        internal NodeCollection<Attachment>? ComplianceAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Compliance field.
        /// </summary>
        public DataList<Attachment>? ComplianceAttachments
        {
            get => ComplianceAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The URI where the app can be configured. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [JsonProperty("configurationUriTemplate")]
        public string? ConfigurationUriTemplate { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the app offering.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the app offering may not be used for new instances.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Feature description of the app offering.
        /// </summary>
        [JsonProperty("features")]
        public string? Features { get; internal set; }

        [JsonProperty("featuresAttachments")]
        internal NodeCollection<Attachment>? FeaturesAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Features field.
        /// </summary>
        public DataList<Attachment>? FeaturesAttachments
        {
            get => FeaturesAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether this is the latest published version of the app offering or the current draft.
        /// </summary>
        [JsonProperty("latest"), Sdk4meField(true)]
        public bool? Latest { get; internal set; }

        /// <summary>
        /// Name of the app offering.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The algorithm used for generating the policy for the app's webhook.
        /// </summary>
        [JsonProperty("policyJwtAlg")]
        public WebhookPolicyJwtAlg? PolicyJwtAlg { get; internal set; }

        /// <summary>
        /// The audience for the policy for the app's webhook.
        /// </summary>
        [JsonProperty("policyJwtAudience")]
        public string? PolicyJwtAudience { get; internal set; }

        /// <summary>
        /// The claim expiry time for the policy for the app's webhook.
        /// </summary>
        [JsonProperty("policyJwtClaimExpiresIn")]
        public long? PolicyJwtClaimExpiresIn { get; internal set; }

        /// <summary>
        /// Whether this app offering is published or draft.
        /// </summary>
        [JsonProperty("published"), Sdk4meField(true)]
        public bool? Published { get; internal set; }

        /// <summary>
        /// This reference can be used to link the app offering to an instance using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; internal set; }

        /// <summary>
        /// This app requires an enabled OAuth person.
        /// </summary>
        [JsonProperty("requiresEnabledOauthPerson")]
        public bool? RequiresEnabledOauthPerson { get; internal set; }

        /// <summary>
        /// Scopes of this app offering.
        /// </summary>
        [JsonProperty("scopes")]
        public List<AppOfferingScope>? Scopes { get; internal set; }

        /// <summary>
        /// Service instance that is linked to the app offering.
        /// </summary>
        [JsonProperty("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// UI extension version that is linked to the app offering.
        /// </summary>
        [JsonProperty("uiExtensionVersion")]
        public UiExtensionVersion? UiExtensionVersion { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The URI for the app's webhook. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [JsonProperty("webhookUriTemplate")]
        public string? WebhookUriTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AppInstancesCollection?.GetQueryPageInfo("appInstances", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(ComplianceAttachmentsCollection?.GetQueryPageInfo("complianceAttachments", depth + 1));
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(FeaturesAttachmentsCollection?.GetQueryPageInfo("featuresAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AppInstances?.AddRange((data as AppOffering)?.AppInstances);
            AutomationRules?.AddRange((data as AppOffering)?.AutomationRules);
            ComplianceAttachments?.AddRange((data as AppOffering)?.ComplianceAttachments);
            DescriptionAttachments?.AddRange((data as AppOffering)?.DescriptionAttachments);
            FeaturesAttachments?.AddRange((data as AppOffering)?.FeaturesAttachments);
        }
    }
}
