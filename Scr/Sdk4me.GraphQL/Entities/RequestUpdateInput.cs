using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/requestupdateinput/">RequestUpdateInput</see> object.
    /// </summary>
    public class RequestUpdateInput : PropertyChangeSet
    {
        private bool? addressed;
        private string? agileBoardColumnId;
        private long? agileBoardColumnPosition;
        private string? agileBoardId;
        private RequestCategory? category;
        private string? clientMutationId;
        private RequestCompletionReason? completionReason;
        private List<string>? configurationItemIds;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private DateTime? desiredCompletionAt;
        private DateTime? downtimeEndAt;
        private DateTime? downtimeStartAt;
        private string? groupedIntoId;
        private string id;
        private RequestImpact? impact;
        private string? internalNote;
        private List<AttachmentInput>? internalNoteAttachments;
        private string? knowledgeArticleId;
        private List<string>? knowledgeArticleIds;
        private RequestMajorIncidentStatus? majorIncidentStatus;
        private string? memberId;
        private List<TagInput>? newTags;
        private List<WatchInput>? newWatches;
        private string? note;
        private List<AttachmentInput>? noteAttachments;
        private string? problemId;
        private long? productBacklogEstimate;
        private string? productBacklogId;
        private long? productBacklogPosition;
        private string? projectId;
        private bool? providerNotAccountable;
        private string? requestedById;
        private string? requestedForId;
        private bool? reviewed;
        private string? serviceInstanceId;
        private string? source;
        private string? sourceID;
        private RequestStatus? status;
        private string? subject;
        private string? supplierId;
        private string? supplierRequestID;
        private List<string>? tagsToDelete;
        private string? teamId;
        private string? templateId;
        private long? timeSpent;
        private string? timeSpentEffortClassId;
        private bool? urgent;
        private DateTime? waitingUntil;
        private List<string>? watchesToDelete;
        private string? workflowId;

        /// <summary>
        /// Default: <c>false</c> - When the Satisfaction field of the request is set to 'Dissatisfied', a person who has the Service Desk Manager role, can check the Addressed box to indicate that the requester has been conciliated.
        /// </summary>
        [JsonProperty("addressed")]
        public bool? Addressed
        {
            get => addressed;
            set => addressed = Set("addressed", value);
        }

        /// <summary>
        /// ID of the column this item is placed in.
        /// </summary>
        [JsonProperty("agileBoardColumnId")]
        public string? AgileBoardColumnId
        {
            get => agileBoardColumnId;
            set => agileBoardColumnId = Set("agileBoardColumnId", value);
        }

        /// <summary>
        /// The (one based) position of this item in its column.
        /// </summary>
        [JsonProperty("agileBoardColumnPosition")]
        public long? AgileBoardColumnPosition
        {
            get => agileBoardColumnPosition;
            set => agileBoardColumnPosition = Set("agileBoardColumnPosition", value);
        }

        /// <summary>
        /// ID of the board this item is placed on.
        /// </summary>
        [JsonProperty("agileBoardId")]
        public string? AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// The Category field is used to select the category of the request.
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
        /// The appropriate completion reason for the request when it has been completed.
        /// </summary>
        [JsonProperty("completionReason")]
        public RequestCompletionReason? CompletionReason
        {
            get => completionReason;
            set => completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// Identifiers of the configuration items to relate to the request. When this field is used to update an existing request, all configuration items that were linked to this request will be replaced by the supplied configuration items.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
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
        /// The date and time that has been agreed on for the completion of the request. The desired completion overwrites the automatically calculated resolution target of any affected SLA that is related to the request when the desired completion is later than the affected SLA's resolution target. By default, the person selected in the Requested by field receives a notification based on the 'Desired Completion Set for Request' email template whenever the value in the Desired completion field is set, updated or removed.
        /// </summary>
        [JsonProperty("desiredCompletionAt")]
        public DateTime? DesiredCompletionAt
        {
            get => desiredCompletionAt;
            set => desiredCompletionAt = Set("desiredCompletionAt", value);
        }

        /// <summary>
        /// Used to specify the actual date and time at which the service became available again.
        /// </summary>
        [JsonProperty("downtimeEndAt")]
        public DateTime? DowntimeEndAt
        {
            get => downtimeEndAt;
            set => downtimeEndAt = Set("downtimeEndAt", value);
        }

        /// <summary>
        /// Used to specify the actual date and time at which the service outage started.
        /// </summary>
        [JsonProperty("downtimeStartAt")]
        public DateTime? DowntimeStartAt
        {
            get => downtimeStartAt;
            set => downtimeStartAt = Set("downtimeStartAt", value);
        }

        /// <summary>
        /// ID of the request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        [JsonProperty("groupedIntoId")]
        public string? GroupedIntoId
        {
            get => groupedIntoId;
            set => groupedIntoId = Set("groupedIntoId", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Used to select the extent to which the service instance is impacted.
        /// </summary>
        [JsonProperty("impact")]
        public RequestImpact? Impact
        {
            get => impact;
            set => impact = Set("impact", value);
        }

        /// <summary>
        /// Used to provide information that is visible only for people who have the Auditor, Specialist or Account Administrator role of the account for which the internal note is intended. The <c>X-4me-Account</c> header sent determines the account.
        /// </summary>
        [JsonProperty("internalNote")]
        public string? InternalNote
        {
            get => internalNote;
            set => internalNote = Set("internalNote", value);
        }

        /// <summary>
        /// The attachments used in the <c>internalNote</c> field.
        /// </summary>
        [JsonProperty("internalNoteAttachments")]
        public List<AttachmentInput>? InternalNoteAttachments
        {
            get => internalNoteAttachments;
            set => internalNoteAttachments = Set("internalNoteAttachments", value);
        }

        /// <summary>
        /// Latest knowledge article applied to the request.
        /// </summary>
        [Obsolete("Use `knowledgeArticleIds` instead.")]
        [JsonProperty("knowledgeArticleId")]
        public string? KnowledgeArticleId
        {
            get => knowledgeArticleId;
            set => knowledgeArticleId = Set("knowledgeArticleId", value);
        }

        /// <summary>
        /// Knowledge articles applied to the request.
        /// </summary>
        [JsonProperty("knowledgeArticleIds")]
        public List<string>? KnowledgeArticleIds
        {
            get => knowledgeArticleIds;
            set => knowledgeArticleIds = Set("knowledgeArticleIds", value);
        }

        /// <summary>
        /// Used to indicate the status in the major incident management process.
        /// </summary>
        [JsonProperty("majorIncidentStatus")]
        public RequestMajorIncidentStatus? MajorIncidentStatus
        {
            get => majorIncidentStatus;
            set => majorIncidentStatus = Set("majorIncidentStatus", value);
        }

        /// <summary>
        /// ID of the person to whom the request is to be assigned.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// Tags to be added to the request.
        /// </summary>
        [JsonProperty("newTags")]
        public List<TagInput>? NewTags
        {
            get => newTags;
            set => newTags = Set("newTags", value);
        }

        /// <summary>
        /// New or updated watches.
        /// </summary>
        [JsonProperty("newWatches")]
        public List<WatchInput>? NewWatches
        {
            get => newWatches;
            set => newWatches = Set("newWatches", value);
        }

        /// <summary>
        /// Any additional information that could prove useful for resolving the request and/or to provide a summary of the actions that have been taken since the last entry.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// The attachments used in the <c>note</c> field.
        /// </summary>
        [JsonProperty("noteAttachments")]
        public List<AttachmentInput>? NoteAttachments
        {
            get => noteAttachments;
            set => noteAttachments = Set("noteAttachments", value);
        }

        /// <summary>
        /// ID of problem to link request to.
        /// </summary>
        [JsonProperty("problemId")]
        public string? ProblemId
        {
            get => problemId;
            set => problemId = Set("problemId", value);
        }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [JsonProperty("productBacklogEstimate")]
        public long? ProductBacklogEstimate
        {
            get => productBacklogEstimate;
            set => productBacklogEstimate = Set("productBacklogEstimate", value);
        }

        /// <summary>
        /// Identifier of the product backlog this item is placed on.
        /// </summary>
        [JsonProperty("productBacklogId")]
        public string? ProductBacklogId
        {
            get => productBacklogId;
            set => productBacklogId = Set("productBacklogId", value);
        }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [JsonProperty("productBacklogPosition")]
        public long? ProductBacklogPosition
        {
            get => productBacklogPosition;
            set => productBacklogPosition = Set("productBacklogPosition", value);
        }

        /// <summary>
        /// ID of project to link request to.
        /// </summary>
        [JsonProperty("projectId")]
        public string? ProjectId
        {
            get => projectId;
            set => projectId = Set("projectId", value);
        }

        /// <summary>
        /// Default: <c>false</c> - Whether the provider currently indicates not to be accountable.
        /// </summary>
        [JsonProperty("providerNotAccountable")]
        public bool? ProviderNotAccountable
        {
            get => providerNotAccountable;
            set => providerNotAccountable = Set("providerNotAccountable", value);
        }

        /// <summary>
        /// ID of the person who submitted the request. Defaults to the Requested for field if its value was explicitely provided, otherwise it defaults to the current authenticated person
        /// </summary>
        [JsonProperty("requestedById")]
        public string? RequestedById
        {
            get => requestedById;
            set => requestedById = Set("requestedById", value);
        }

        /// <summary>
        /// ID of the person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        [JsonProperty("requestedForId")]
        public string? RequestedForId
        {
            get => requestedForId;
            set => requestedForId = Set("requestedForId", value);
        }

        /// <summary>
        /// Default: <c>false</c> - A request can be marked as reviewed by the problem manager of the service of the service instance that is linked to the request. Marking a request as reviewed excludes it from the 'Requests for Problem Identification' view.
        /// </summary>
        [JsonProperty("reviewed")]
        public bool? Reviewed
        {
            get => reviewed;
            set => reviewed = Set("reviewed", value);
        }

        /// <summary>
        /// ID of the service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        [JsonProperty("serviceInstanceId")]
        public string? ServiceInstanceId
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
        /// Default: <c>assigned</c> - Used to select the current status of the request.
        /// </summary>
        [JsonProperty("status")]
        public RequestStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the request.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// ID of the supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => supplierRequestID;
            set => supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// Identifiers of tags to delete.
        /// </summary>
        [JsonProperty("tagsToDelete")]
        public List<string>? TagsToDelete
        {
            get => tagsToDelete;
            set => tagsToDelete = Set("tagsToDelete", value);
        }

        /// <summary>
        /// ID of the team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// ID of the request template to apply to the request.
        /// </summary>
        [JsonProperty("templateId")]
        public string? TemplateId
        {
            get => templateId;
            set => templateId = Set("templateId", value);
        }

        /// <summary>
        /// The time that you have spent working on the request since you started to work on it or, if you already entered some time for this request, since you last added your time spent in it.
        /// </summary>
        [JsonProperty("timeSpent")]
        public long? TimeSpent
        {
            get => timeSpent;
            set => timeSpent = Set("timeSpent", value);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [JsonProperty("timeSpentEffortClassId")]
        public string? TimeSpentEffortClassId
        {
            get => timeSpentEffortClassId;
            set => timeSpentEffortClassId = Set("timeSpentEffortClassId", value);
        }

        /// <summary>
        /// Setting to <c>true</c> marks request as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the request is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => waitingUntil;
            set => waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// Identifiers of watches to delete.
        /// </summary>
        [JsonProperty("watchesToDelete")]
        public List<string>? WatchesToDelete
        {
            get => watchesToDelete;
            set => watchesToDelete = Set("watchesToDelete", value);
        }

        /// <summary>
        /// ID of workflow to link request to.
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId
        {
            get => workflowId;
            set => workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateInput"/> class without providing the required values.
        /// </summary>
        public RequestUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public RequestUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
