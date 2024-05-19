using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/requesttemplateupdateinput/">RequestTemplateUpdateInput</see> object.
    /// </summary>
    public class RequestTemplateUpdateInput : PropertyChangeSet
    {
        private bool? assetSelection;
        private bool? assignToSelf;
        private RequestCategory? category;
        private string? clientMutationId;
        private RequestCompletionReason? completionReason;
        private string? configurationItemId;
        private bool? copySubjectToRequests;
        private long? desiredCompletion;
        private bool? disabled;
        private string? effortClassId;
        private bool? endUsers;
        private string id;
        private RequestImpact? impact;
        private string? instructions;
        private string? keywords;
        private string? memberId;
        private string? note;
        private string? registrationHints;
        private List<string>? reservationOfferingIds;
        private string? serviceId;
        private string? source;
        private string? sourceID;
        private bool? specialists;
        private RequestStatus? status;
        private string? subject;
        private string? supplierId;
        private string? supportHoursId;
        private string? teamId;
        private string? timeZone;
        private string? uiExtensionId;
        private bool? urgent;
        private string? workflowManagerId;
        private string? workflowTemplateId;

        /// <summary>
        /// After selecting the request template in Self Service, the user needs to be able to select a configuration item in the Asset field.
        /// </summary>
        [JsonProperty("assetSelection")]
        public bool? AssetSelection
        {
            get => assetSelection;
            set => assetSelection = Set("assetSelection", value);
        }

        /// <summary>
        /// Whether the person who is registering a new request based on the template is selected in its Member field.
        /// </summary>
        [JsonProperty("assignToSelf")]
        public bool? AssignToSelf
        {
            get => assignToSelf;
            set => assignToSelf = Set("assignToSelf", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("category")]
        public RequestCategory? Category
        {
            get => category;
            set => category = Set("category", value);
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
        /// The completion reason that needs to be selected in the Completion reason field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("completionReason")]
        public RequestCompletionReason? CompletionReason
        {
            get => completionReason;
            set => completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// Identifier of the CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("configurationItemId")]
        public string? ConfigurationItemId
        {
            get => configurationItemId;
            set => configurationItemId = Set("configurationItemId", value);
        }

        /// <summary>
        /// Whether the subject of the request template needs to become the subject of a request when the template is applied, provided that the Subject field of this request is empty.
        /// </summary>
        [JsonProperty("copySubjectToRequests")]
        public bool? CopySubjectToRequests
        {
            get => copySubjectToRequests;
            set => copySubjectToRequests = Set("copySubjectToRequests", value);
        }

        /// <summary>
        /// Used to enter the number of minutes within which requests that are based on the request template are to be resolved.
        /// </summary>
        [JsonProperty("desiredCompletion")]
        public long? DesiredCompletion
        {
            get => desiredCompletion;
            set => desiredCompletion = Set("desiredCompletion", value);
        }

        /// <summary>
        /// Whether the request template may not be used to help register new requests.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Whether the request template is shown to end users in Self Service.
        /// </summary>
        [JsonProperty("endUsers")]
        public bool? EndUsers
        {
            get => endUsers;
            set => endUsers = Set("endUsers", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("impact")]
        public RequestImpact? Impact
        {
            get => impact;
            set => impact = Set("impact", value);
        }

        /// <summary>
        /// Instructions for the support staff who will work on requests that are based on the template.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the request template using search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords
        {
            get => keywords;
            set => keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// The information that needs to be displayed after the template has been applied to a new or existing request. This field typically contains step-by-step instructions about how to complete the registration of a request that is based on the template.
        /// </summary>
        [JsonProperty("registrationHints")]
        public string? RegistrationHints
        {
            get => registrationHints;
            set => registrationHints = Set("registrationHints", value);
        }

        /// <summary>
        /// Identifiers of reservation offerings related to the request template.
        /// </summary>
        [JsonProperty("reservationOfferingIds")]
        public List<string>? ReservationOfferingIds
        {
            get => reservationOfferingIds;
            set => reservationOfferingIds = Set("reservationOfferingIds", value);
        }

        /// <summary>
        /// Identifier of the service for which the request template is made available.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
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
        /// Whether the request template is shown to Specialists.
        /// </summary>
        [JsonProperty("specialists")]
        public bool? Specialists
        {
            get => specialists;
            set => specialists = Set("specialists", value);
        }

        /// <summary>
        /// Used to select the status value that needs to be selected in the Status field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("status")]
        public RequestStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        [JsonProperty("supportHoursId")]
        public string? SupportHoursId
        {
            get => supportHoursId;
            set => supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// Identifier of the team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the selected support hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
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
        /// Whether a new request that is created based on the template is to be marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// Identifier of the Workflow Manager linked to the request template. <em>Required</em> when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        [JsonProperty("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => workflowManagerId;
            set => workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// Identifier of the Workflow Template related to the request template. <em>Required</em> when the <em>Status</em> is set to _Workflow Pending_.
        /// </summary>
        [JsonProperty("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => workflowTemplateId;
            set => workflowTemplateId = Set("workflowTemplateId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateUpdateInput"/> class without providing the required values.
        /// </summary>
        public RequestTemplateUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public RequestTemplateUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
