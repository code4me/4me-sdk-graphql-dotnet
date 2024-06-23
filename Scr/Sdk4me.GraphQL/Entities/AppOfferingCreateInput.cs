using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingcreateinput/">AppOfferingCreateInput</see> object.
    /// </summary>
    public class AppOfferingCreateInput : PropertyChangeSet
    {
        private string? cardDescription;
        private string? clientMutationId;
        private string? compliance;
        private string? configurationUriTemplate;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string? features;
        private string name;
        private List<AppOfferingScopeInput>? newScopes;
        private List<string>? oauthAuthorizationEndpoints;
        private string? pictureUri;
        private WebhookPolicyJwtAlg? policyJwtAlg;
        private string? policyJwtAudience;
        private long? policyJwtClaimExpiresIn;
        private string? reference;
        private bool? requiresEnabledOauthPerson;
        private string serviceInstanceId;
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;
        private string? uiExtensionVersionId;
        private string? webhookUriTemplate;

        /// <summary>
        /// Short description of the app offering to be shown on the card in the App store.
        /// </summary>
        [JsonProperty("cardDescription")]
        public string? CardDescription
        {
            get => cardDescription;
            set => cardDescription = Set("cardDescription", value);
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

        /// <summary>
        /// Compliance description of the app offering.
        /// </summary>
        [JsonProperty("compliance")]
        public string? Compliance
        {
            get => compliance;
            set => compliance = Set("compliance", value);
        }

        /// <summary>
        /// The URI where the app can be configured. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [JsonProperty("configurationUriTemplate")]
        public string? ConfigurationUriTemplate
        {
            get => configurationUriTemplate;
            set => configurationUriTemplate = Set("configurationUriTemplate", value);
        }

        /// <summary>
        /// Description of the app offering.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [JsonProperty("descriptionAttachments")]
        public List<AttachmentInput>? DescriptionAttachments
        {
            get => descriptionAttachments;
            set => descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the app offering may not be used for new instances.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Feature description of the app offering.
        /// </summary>
        [JsonProperty("features")]
        public string? Features
        {
            get => features;
            set => features = Set("features", value);
        }

        /// <summary>
        /// Name of the app offering.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Scopes of this app offering
        /// </summary>
        [JsonProperty("newScopes")]
        public List<AppOfferingScopeInput>? NewScopes
        {
            get => newScopes;
            set => newScopes = Set("newScopes", value);
        }

        /// <summary>
        /// The endpoints for the OAuth application that will be created for this app to use in the <see href="https://developer.4me.com/v1/oauth/authorization_code_grant/">Authorization Code Grant flow</see>.
        /// </summary>
        [JsonProperty("oauthAuthorizationEndpoints")]
        public List<string>? OauthAuthorizationEndpoints
        {
            get => oauthAuthorizationEndpoints;
            set => oauthAuthorizationEndpoints = Set("oauthAuthorizationEndpoints", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// The algorithm used for generating the policy for the app offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtAlg")]
        public WebhookPolicyJwtAlg? PolicyJwtAlg
        {
            get => policyJwtAlg;
            set => policyJwtAlg = Set("policyJwtAlg", value);
        }

        /// <summary>
        /// The audience for the policy for the app offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtAudience")]
        public string? PolicyJwtAudience
        {
            get => policyJwtAudience;
            set => policyJwtAudience = Set("policyJwtAudience", value);
        }

        /// <summary>
        /// The claim expiry time for the policy for the app offering's webhook.
        /// </summary>
        [JsonProperty("policyJwtClaimExpiresIn")]
        public long? PolicyJwtClaimExpiresIn
        {
            get => policyJwtClaimExpiresIn;
            set => policyJwtClaimExpiresIn = Set("policyJwtClaimExpiresIn", value);
        }

        /// <summary>
        /// This reference can be used to link the app offering to an instance using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
        }

        /// <summary>
        /// This app requires an enabled OAuth person.
        /// </summary>
        [JsonProperty("requiresEnabledOauthPerson")]
        public bool? RequiresEnabledOauthPerson
        {
            get => requiresEnabledOauthPerson;
            set => requiresEnabledOauthPerson = Set("requiresEnabledOauthPerson", value);
        }

        /// <summary>
        /// Identifier of the the service instance this app offering is linked to.
        /// </summary>
        [JsonProperty("serviceInstanceId"), Sdk4meField(IsRequiredForMutation = true)]
        public string ServiceInstanceId
        {
            get => serviceInstanceId;
            set => serviceInstanceId = Set("serviceInstanceId", value);
        }

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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Identifier of the UI extension version that is linked to the app offering.
        /// </summary>
        [JsonProperty("uiExtensionVersionId")]
        public string? UiExtensionVersionId
        {
            get => uiExtensionVersionId;
            set => uiExtensionVersionId = Set("uiExtensionVersionId", value);
        }

        /// <summary>
        /// The URI for the app offering's webhook. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [JsonProperty("webhookUriTemplate")]
        public string? WebhookUriTemplate
        {
            get => webhookUriTemplate;
            set => webhookUriTemplate = Set("webhookUriTemplate", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingCreateInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingCreateInput()
        {
            name = string.Empty;
            serviceInstanceId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingCreateInput"/> class.
        /// </summary>
        /// <param name="name">Name of the app offering.</param>
        /// <param name="serviceInstanceId">Identifier of the the service instance this app offering is linked to.</param>
        public AppOfferingCreateInput(string name, string serviceInstanceId)
        {
            this.name = Set("name", name);
            this.serviceInstanceId = Set("serviceInstanceId", serviceInstanceId);
        }
    }
}
