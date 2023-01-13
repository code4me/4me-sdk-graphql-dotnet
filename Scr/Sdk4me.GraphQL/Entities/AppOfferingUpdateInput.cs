namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingupdateinput/">AppOfferingUpdateInput</see> object.
    /// </summary>
    public class AppOfferingUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;
        private string? compliance;
        private string? description;
        private bool? disabled;
        private string? features;
        private string? name;
        private WebhookPolicyJwtAlg? policyJwtAlg;
        private string? policyJwtAudience;
        private long? policyJwtClaimExpiresIn;
        private string? reference;
        private string? serviceInstanceId;
        private string? uiExtensionVersionId;
        private string? configurationUriTemplate;
        private string? webhookUriTemplate;
        private List<AppOfferingScopeInput>? newScopes;
        private string? id;
        private List<string>? scopesToDelete;
        private string? clientMutationId;

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// User interface extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Compliance description of the application offering.
        /// </summary>
        [JsonProperty("compliance")]
        public string? Compliance
        {
            get => compliance;
            set => compliance = Set("compliance", value);
        }

        /// <summary>
        /// Description of the application offering.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Whether the application offering may not be used for new instances.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Feature description of the application offering.
        /// </summary>
        [JsonProperty("features")]
        public string? Features
        {
            get => features;
            set => features = Set("features", value);
        }

        /// <summary>
        /// Name of the application offering.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The algorithm used for generating the policy for the application offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtAlg")]
        public WebhookPolicyJwtAlg? PolicyJwtAlg
        {
            get => policyJwtAlg;
            set => policyJwtAlg = Set("policyJwtAlg", value);
        }

        /// <summary>
        /// The audience for the policy for the application offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtAudience")]
        public string? PolicyJwtAudience
        {
            get => policyJwtAudience;
            set => policyJwtAudience = Set("policyJwtAudience", value);
        }

        /// <summary>
        /// The claim expiry time for the policy for the application offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtClaimExpiresIn")]
        public long? PolicyJwtClaimExpiresIn
        {
            get => policyJwtClaimExpiresIn;
            set => policyJwtClaimExpiresIn = Set("policyJwtClaimExpiresIn", value);
        }

        /// <summary>
        /// This reference can be used to link the application offering to an instance using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
        }

        /// <summary>
        /// Identifier of the the service instance this application offering is linked to.
        /// </summary>
        [JsonProperty("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => serviceInstanceId;
            set => serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// Identifier of the user interface extension version that is linked to the application offering.
        /// </summary>
        [JsonProperty("uiExtensionVersionId")]
        public string? UiExtensionVersionId
        {
            get => uiExtensionVersionId;
            set => uiExtensionVersionId = Set("uiExtensionVersionId", value);
        }

        /// <summary>
        /// The uniform resource identifier where the application can be configured. The placeholder {account} can be used to include the customer account identifier in the uniform resource identifier.
        /// </summary>
        [JsonProperty("configurationUriTemplate")]
        public string? ConfigurationUriTemplate
        {
            get => configurationUriTemplate;
            set => configurationUriTemplate = Set("configurationUriTemplate", value);
        }

        /// <summary>
        /// The uniform resource identifier for the application offering's webhook. The placeholder {account} can be used to include the customer account identifier in the uniform resource identifier.
        /// </summary>
        [JsonProperty("webhookUriTemplate")]
        public string? WebhookUriTemplate
        {
            get => webhookUriTemplate;
            set => webhookUriTemplate = Set("webhookUriTemplate", value);
        }

        /// <summary>
        /// Scopes of this application offering.
        /// </summary>
        [JsonProperty("newScopes")]
        public List<AppOfferingScopeInput>? NewScopes
        {
            get => newScopes;
            set => newScopes = Set("newScopes", value);
        }

        /// <summary>
        /// The node identifier of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of scopes to remove from the application offering.
        /// </summary>
        [JsonProperty("scopesToDelete")]
        public List<string>? ScopesToDelete
        {
            get => scopesToDelete;
            set => scopesToDelete = Set("scopesToDelete", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }
    }
}
