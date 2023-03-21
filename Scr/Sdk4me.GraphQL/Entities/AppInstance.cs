namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appinstance/">AppInstance</see> object.
    /// </summary>
    public class AppInstance : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// App offering (version) this instance is at.
        /// </summary>
        [JsonProperty("appOffering")]
        public AppOffering? AppOffering { get; internal set; }

        [JsonProperty("automationRules")]
        internal NodeCollection<AutomationRule>? AutomationRulesCollection { get; set; }

        /// <summary>
        /// Automation rules of this instance.
        /// </summary>
        public DataList<AutomationRule>? AutomationRules
        {
            get => AutomationRulesCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Account this app instance is for.
        /// </summary>
        [JsonProperty("customerAccount")]
        public Account? CustomerAccount { get; internal set; }

        /// <summary>
        /// Contact person of customer regarding this app instance.
        /// </summary>
        [JsonProperty("customerRepresentative")]
        public Person? CustomerRepresentative { get; internal set; }

        /// <summary>
        /// Whether the app instance is currently enabled for this customer.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Whether the customer has enabled this app instance.
        /// </summary>
        [JsonProperty("enabledByCustomer"), Sdk4meField(true)]
        public bool? EnabledByCustomer { get; internal set; }

        /// <summary>
        /// Whether the app is currently suspended for this customer.
        /// </summary>
        [JsonProperty("suspended")]
        public bool? Suspended { get; internal set; }

        /// <summary>
        /// Extra information why the app is currently suspended for this customer.
        /// </summary>
        [JsonProperty("suspensionComment")]
        public string? SuspensionComment { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Webhook of this app instance.
        /// </summary>
        [JsonProperty("webhook"), Sdk4meField(true)]
        public Webhook? Webhook { get; internal set; }

        /// <summary>
        /// The current policy used for the instance's webhook.
        /// </summary>
        [JsonProperty("webhookPolicy")]
        public WebhookPolicy? WebhookPolicy { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as AppInstance)?.AutomationRules);
            CustomFieldsAttachments?.AddRange((data as AppInstance)?.CustomFieldsAttachments);
        }
    }
}
