using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/servicecreateinput/">ServiceCreateInput</see> object.
    /// </summary>
    public class ServiceCreateInput : PropertyChangeSet
    {
        private string? availabilityManagerId;
        private string? capacityManagerId;
        private string? changeManagerId;
        private string? clientMutationId;
        private string? continuityManagerId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string? firstLineTeamId;
        private string? keywords;
        private string? knowledgeManagerId;
        private string? name;
        private string? pictureUri;
        private string? problemManagerId;
        private string? providerId;
        private string? releaseManagerId;
        private string? serviceOwnerId;
        private string? source;
        private string? sourceID;
        private string? supportTeamId;
        private string? surveyId;
        private string? uiExtensionId;

        /// <summary>
        /// Identifier of the person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        [JsonProperty("availabilityManagerId")]
        public string? AvailabilityManagerId
        {
            get => availabilityManagerId;
            set => availabilityManagerId = Set("availabilityManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        [JsonProperty("capacityManagerId")]
        public string? CapacityManagerId
        {
            get => capacityManagerId;
            set => capacityManagerId = Set("capacityManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the changes of the service.
        /// </summary>
        [JsonProperty("changeManagerId")]
        public string? ChangeManagerId
        {
            get => changeManagerId;
            set => changeManagerId = Set("changeManagerId", value);
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
        /// Identifier of the person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        [JsonProperty("continuityManagerId")]
        public string? ContinuityManagerId
        {
            get => continuityManagerId;
            set => continuityManagerId = Set("continuityManagerId", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// A high-level description of the service's core functionality.
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
        /// Whether the service may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        [JsonProperty("firstLineTeamId")]
        public string? FirstLineTeamId
        {
            get => firstLineTeamId;
            set => firstLineTeamId = Set("firstLineTeamId", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the service via search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords
        {
            get => keywords;
            set => keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        [JsonProperty("knowledgeManagerId")]
        public string? KnowledgeManagerId
        {
            get => knowledgeManagerId;
            set => knowledgeManagerId = Set("knowledgeManagerId", value);
        }

        /// <summary>
        /// The name of the service. The service name may be followed by the name of its core application placed between brackets.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
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
        /// Identifier of the person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        [JsonProperty("problemManagerId")]
        public string? ProblemManagerId
        {
            get => problemManagerId;
            set => problemManagerId = Set("problemManagerId", value);
        }

        /// <summary>
        /// Identifier of the organization who provides the service.
        /// </summary>
        [JsonProperty("providerId")]
        public string? ProviderId
        {
            get => providerId;
            set => providerId = Set("providerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the releases of the service.
        /// </summary>
        [JsonProperty("releaseManagerId")]
        public string? ReleaseManagerId
        {
            get => releaseManagerId;
            set => releaseManagerId = Set("releaseManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        [JsonProperty("serviceOwnerId")]
        public string? ServiceOwnerId
        {
            get => serviceOwnerId;
            set => serviceOwnerId = Set("serviceOwnerId", value);
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
        /// Identifier of the team that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        [JsonProperty("supportTeamId")]
        public string? SupportTeamId
        {
            get => supportTeamId;
            set => supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// Identifier of the survey used to measure customer rating of this service.
        /// </summary>
        [JsonProperty("surveyId")]
        public string? SurveyId
        {
            get => surveyId;
            set => surveyId = Set("surveyId", value);
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
    }
}
