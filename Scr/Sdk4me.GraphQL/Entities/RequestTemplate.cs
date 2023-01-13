namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/requesttemplate/">RequestTemplate</see> object.
    /// </summary>
    public class RequestTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// After selecting the request template in Self Service, the user needs to be able to select a configuration item in the Asset field.
        /// </summary>
        [JsonProperty("assetSelection")]
        public bool? AssetSelection { get; internal set; }

        /// <summary>
        /// Whether the request will be assigned to the provided Team after the workflow is completed. When `false` the request will be completed after the workflow completes.
        /// </summary>
        [JsonProperty("assignAfterWorkflowCompletion")]
        public bool? AssignAfterWorkflowCompletion { get; internal set; }

        /// <summary>
        /// Whether the person who is registering a new request based on the template is selected in its Member field.
        /// </summary>
        [JsonProperty("assignToSelf")]
        public bool? AssignToSelf { get; internal set; }

        [JsonProperty("automationRules")]
        internal NodeCollection<AutomationRule>? AutomationRulesCollection { get; set; }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public DataList<AutomationRule>? AutomationRules
        {
            get => AutomationRulesCollection?.Data;
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public RequestCategory? Category { get; internal set; }

        /// <summary>
        /// The completion reason that needs to be selected in the Completion reason field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("completionReason")]
        public RequestCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// The configuration item that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// Whether the subject of the request template needs to become the subject of a request when the template is applied, provided that the Subject field of this request is empty.
        /// </summary>
        [JsonProperty("copySubjectToRequests")]
        public bool? CopySubjectToRequests { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Used to enter the number of minutes within which requests that are based on the request template are to be resolved.
        /// </summary>
        [JsonProperty("desiredCompletion")]
        public long? DesiredCompletion { get; internal set; }

        /// <summary>
        /// Whether the request template may not be used to help register new requests.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Whether the request template is shown to end users in Self Service.
        /// </summary>
        [JsonProperty("endUsers")]
        public bool? EndUsers { get; internal set; }

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public RequestImpact? Impact { get; internal set; }

        /// <summary>
        /// Instructions for the support staff who will work on requests that are based on the template.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions { get; internal set; }

        [JsonProperty("instructionsAttachments")]
        internal NodeCollection<Attachment>? InstructionsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public DataList<Attachment>? InstructionsAttachments
        {
            get => InstructionsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the request template using search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords { get; internal set; }

        /// <summary>
        /// Used to select the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; internal set; }

        [JsonProperty("noteAttachments")]
        internal NodeCollection<Attachment>? NoteAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public DataList<Attachment>? NoteAttachments
        {
            get => NoteAttachmentsCollection?.Data;
        }

        [JsonProperty("organizations")]
        internal NodeCollection<Organization>? OrganizationsCollection { get; set; }

        /// <summary>
        /// Organizations related to the order request template.
        /// </summary>
        public DataList<Organization>? Organizations
        {
            get => OrganizationsCollection?.Data;
        }

        /// <summary>
        /// The number of minutes that is expected to be spent working on a request that is created based on the template.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The information that needs to be displayed after the template has been applied to a new or existing request. This field typically contains step-by-step instructions about how to complete the registration of a request that is based on the template.
        /// </summary>
        [JsonProperty("registrationHints")]
        public string? RegistrationHints { get; internal set; }

        [JsonProperty("registrationHintsAttachments")]
        internal NodeCollection<Attachment>? RegistrationHintsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Registration hints field.
        /// </summary>
        public DataList<Attachment>? RegistrationHintsAttachments
        {
            get => RegistrationHintsAttachmentsCollection?.Data;
        }

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// Requests created using the request template.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        [JsonProperty("reservationOfferings")]
        internal NodeCollection<ReservationOffering>? ReservationOfferingsCollection { get; set; }

        /// <summary>
        /// Reservation offerings related to the request template.
        /// </summary>
        public DataList<ReservationOffering>? ReservationOfferings
        {
            get => ReservationOfferingsCollection?.Data;
        }

        /// <summary>
        /// The service for which the request template is made available.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

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
        /// Whether the request template is shown to Specialists.
        /// </summary>
        [JsonProperty("specialists")]
        public bool? Specialists { get; internal set; }

        [JsonProperty("standardServiceRequests")]
        internal NodeCollection<StandardServiceRequest>? StandardServiceRequestsCollection { get; set; }

        /// <summary>
        /// Standard service requests related to the request template.
        /// </summary>
        public DataList<StandardServiceRequest>? StandardServiceRequests
        {
            get => StandardServiceRequestsCollection?.Data;
        }

        /// <summary>
        /// Used to select the status value that needs to be selected in the Status field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("status")]
        public RequestStatus? Status { get; internal set; }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// Used to select the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        [JsonProperty("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// <br>The time zone that applies to the selected support hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// User interface extension that is to be added to a new request when it is being created based on the template.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether a new request that is created based on the template is to be marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Used to relate a Workflow Manager to the request template. _Required_ when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        [JsonProperty("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// Used to relate a Workflow Template to the request template. _Required_ when the _Status_ is set to _Workflow Pending_.
        /// </summary>
        [JsonProperty("workflowTemplate"), Sdk4meField(true)]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NoteAttachmentsCollection?.GetQueryPageInfo("noteAttachments", depth + 1));
            retval.AddRange(OrganizationsCollection?.GetQueryPageInfo("organizations", depth + 1));
            retval.AddRange(RegistrationHintsAttachmentsCollection?.GetQueryPageInfo("registrationHintsAttachments", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(ReservationOfferingsCollection?.GetQueryPageInfo("reservationOfferings", depth + 1));
            retval.AddRange(StandardServiceRequestsCollection?.GetQueryPageInfo("standardServiceRequests", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as RequestTemplate)?.AutomationRules);
            InstructionsAttachments?.AddRange((data as RequestTemplate)?.InstructionsAttachments);
            NoteAttachments?.AddRange((data as RequestTemplate)?.NoteAttachments);
            Organizations?.AddRange((data as RequestTemplate)?.Organizations);
            RegistrationHintsAttachments?.AddRange((data as RequestTemplate)?.RegistrationHintsAttachments);
            Requests?.AddRange((data as RequestTemplate)?.Requests);
            ReservationOfferings?.AddRange((data as RequestTemplate)?.ReservationOfferings);
            StandardServiceRequests?.AddRange((data as RequestTemplate)?.StandardServiceRequests);
            Translations?.AddRange((data as RequestTemplate)?.Translations);
        }
    }
}
