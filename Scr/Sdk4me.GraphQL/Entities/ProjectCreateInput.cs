namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projectcreateinput/">ProjectCreateInput</see> object.
    /// </summary>
    public class ProjectCreateInput : PropertyChangeSet
    {
        private bool? budgetAllocated;
        private string? category;
        private string? clientMutationId;
        private ProjectCompletionReason? completionReason;
        private decimal? costOfEffort;
        private decimal? costOfPurchases;
        private string? customerId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private long? effort;
        private ProjectJustification? justification;
        private string? managerId;
        private List<ProjectPhaseInput>? newPhases;
        private string? note;
        private List<string>? problemIds;
        private string? program;
        private List<string>? requestIds;
        private string? riskLevel;
        private string? serviceId;
        private string? source;
        private string? sourceID;
        private ProjectStatus? status;
        private string? subject;
        private string? timeZone;
        private string? uiExtensionId;
        private decimal? datavalue;
        private List<string>? workflowIds;
        private string? workHoursId;

        /// <summary>
        /// Whether the project has been approved and no longer needs to be considered for funding by portfolio management.
        /// </summary>
        [JsonProperty("budgetAllocated")]
        public bool? BudgetAllocated
        {
            get => budgetAllocated;
            set => budgetAllocated = Set("budgetAllocated", value);
        }

        /// <summary>
        /// The category of the project.
        /// </summary>
        [JsonProperty("category")]
        public string? Category
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
        /// The appropriate completion reason for the project when it has been completed. It is automatically set to "Complete" when all tasks related to the project have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("completionReason")]
        public ProjectCompletionReason? CompletionReason
        {
            get => completionReason;
            set => completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// The estimated cost of the effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [JsonProperty("costOfEffort")]
        public decimal? CostOfEffort
        {
            get => costOfEffort;
            set => costOfEffort = Set("costOfEffort", value);
        }

        /// <summary>
        /// The estimated cost of all purchases (for equipment, consulting effort, licenses, etc.) needed to implement the project. Recurring costs that will be incurred following the implementation of the project are to be included for the entire ROI calculation period.
        /// </summary>
        [JsonProperty("costOfPurchases")]
        public decimal? CostOfPurchases
        {
            get => costOfPurchases;
            set => costOfPurchases = Set("costOfPurchases", value);
        }

        /// <summary>
        /// Identifier of the organization for which the project is to be implemented.
        /// </summary>
        [JsonProperty("customerId")]
        public string? CustomerId
        {
            get => customerId;
            set => customerId = Set("customerId", value);
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
        /// The estimated number of hours of effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [JsonProperty("effort")]
        public long? Effort
        {
            get => effort;
            set => effort = Set("effort", value);
        }

        /// <summary>
        /// The reason why the project should be considered for implementation.
        /// </summary>
        [JsonProperty("justification")]
        public ProjectJustification? Justification
        {
            get => justification;
            set => justification = Set("justification", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the implementation of the project.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// Phases of the project.
        /// </summary>
        [JsonProperty("newPhases")]
        public List<ProjectPhaseInput>? NewPhases
        {
            get => newPhases;
            set => newPhases = Set("newPhases", value);
        }

        /// <summary>
        /// High-level description of the project. It is also used to add any information that could prove useful for anyone involved in the project, including the people whose approval is needed and the people who are helping to implement it.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Identifiers of the problems of the project.
        /// </summary>
        [JsonProperty("problemIds")]
        public List<string>? ProblemIds
        {
            get => problemIds;
            set => problemIds = Set("problemIds", value);
        }

        /// <summary>
        /// Used to indicate which program the project is a part of.
        /// </summary>
        [JsonProperty("program")]
        public string? Program
        {
            get => program;
            set => program = Set("program", value);
        }

        /// <summary>
        /// Identifiers of the requests of the project.
        /// </summary>
        [JsonProperty("requestIds")]
        public List<string>? RequestIds
        {
            get => requestIds;
            set => requestIds = Set("requestIds", value);
        }

        /// <summary>
        /// The risk level of the project.
        /// </summary>
        [JsonProperty("riskLevel")]
        public string? RiskLevel
        {
            get => riskLevel;
            set => riskLevel = Set("riskLevel", value);
        }

        /// <summary>
        /// Identifier of the service for which the project will be implemented.
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
        /// Automatically set based on the status of the project's tasks.
        /// </summary>
        [JsonProperty("status")]
        public ProjectStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the project.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the selected work hours.</br>
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
        /// The estimated financial value that the implementation of the project will deliver for the entire ROI calculation period.
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value
        {
            get => datavalue;
            set => datavalue = Set("value", value);
        }

        /// <summary>
        /// Identifiers of the workflows of the project.
        /// </summary>
        [JsonProperty("workflowIds")]
        public List<string>? WorkflowIds
        {
            get => workflowIds;
            set => workflowIds = Set("workflowIds", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the work hours that are to be used to calculate the anticipated assignment and completion target for the tasks of the project.
        /// </summary>
        [JsonProperty("workHoursId")]
        public string? WorkHoursId
        {
            get => workHoursId;
            set => workHoursId = Set("workHoursId", value);
        }
    }
}
