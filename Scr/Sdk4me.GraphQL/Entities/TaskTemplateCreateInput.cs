using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/tasktemplatecreateinput/">TaskTemplateCreateInput</see> object.
    /// </summary>
    public class TaskTemplateCreateInput : PropertyChangeSet
    {
        private bool? assignToRequester;
        private bool? assignToRequesterBusinessUnitManager;
        private bool? assignToRequesterManager;
        private bool? assignToServiceOwner;
        private bool? assignToWorkflowManager;
        private TaskCategory? category;
        private string? clientMutationId;
        private List<string>? configurationItemIds;
        private bool? copyNotesToWorkflow;
        private bool? disabled;
        private string? effortClassId;
        private TaskImpact? impact;
        private string? instructions;
        private string? memberId;
        private List<TaskTemplateApprovalInput>? newApprovals;
        private string? note;
        private string? pdfDesignId;
        private long? plannedDuration;
        private long? plannedEffort;
        private long? plannedEffortRequester;
        private long? plannedEffortRequesterBusinessUnitManager;
        private long? plannedEffortRequesterManager;
        private long? plannedEffortServiceOwner;
        private long? plannedEffortWorkflowManager;
        private bool? providerNotAccountable;
        private string? requestServiceInstanceId;
        private string? requestTemplateId;
        private long? requiredApprovals;
        private List<string>? serviceInstanceIds;
        private string? source;
        private string? sourceID;
        private string? subject;
        private string? supplierId;
        private string? teamId;
        private string? uiExtensionId;
        private bool? urgent;
        private bool? workHoursAre24x7;

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [JsonProperty("assignToRequester")]
        public bool? AssignToRequester
        {
            get => assignToRequester;
            set => assignToRequester = Set("assignToRequester", value);
        }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [JsonProperty("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager
        {
            get => assignToRequesterBusinessUnitManager;
            set => assignToRequesterBusinessUnitManager = Set("assignToRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// Whether the manager of the requester of the first related request is to be selected in the Approver field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("assignToRequesterManager")]
        public bool? AssignToRequesterManager
        {
            get => assignToRequesterManager;
            set => assignToRequesterManager = Set("assignToRequesterManager", value);
        }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the workflow that the new task is a part of.
        /// </summary>
        [JsonProperty("assignToServiceOwner")]
        public bool? AssignToServiceOwner
        {
            get => assignToServiceOwner;
            set => assignToServiceOwner = Set("assignToServiceOwner", value);
        }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the workflow to which the task belongs.
        /// </summary>
        [JsonProperty("assignToWorkflowManager")]
        public bool? AssignToWorkflowManager
        {
            get => assignToWorkflowManager;
            set => assignToWorkflowManager = Set("assignToWorkflowManager", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("category")]
        public TaskCategory? Category
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
        /// Identifiers of the configuration items of the task template.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Whether the Copy note to workflow box of tasks that were created based on the template needs to be checked by default. (The Copy notes to workflow checkbox is called "Copy notes to workflow by default" when the task template is in Edit mode.)
        /// </summary>
        [JsonProperty("copyNotesToWorkflow")]
        public bool? CopyNotesToWorkflow
        {
            get => copyNotesToWorkflow;
            set => copyNotesToWorkflow = Set("copyNotesToWorkflow", value);
        }

        /// <summary>
        /// Whether the task template may not be used to help register new tasks.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a task created based on the template.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("impact")]
        public TaskImpact? Impact
        {
            get => impact;
            set => impact = Set("impact", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// Identifier of the person who should be selected in the Member field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        [JsonProperty("newApprovals")]
        public List<TaskTemplateApprovalInput>? NewApprovals
        {
            get => newApprovals;
            set => newApprovals = Set("newApprovals", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the PDF design that needs to be copied to the PDF design field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("pdfDesignId")]
        public string? PdfDesignId
        {
            get => pdfDesignId;
            set => pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// The number of minutes that should be entered in the Planned duration field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration
        {
            get => plannedDuration;
            set => plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// The number of minutes the member is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// The number of minutes the person, who is selected in the Requested for field of the first related request, is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequester")]
        public long? PlannedEffortRequester
        {
            get => plannedEffortRequester;
            set => plannedEffortRequester = Set("plannedEffortRequester", value);
        }

        /// <summary>
        /// The number of minutes the business unit manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager
        {
            get => plannedEffortRequesterBusinessUnitManager;
            set => plannedEffortRequesterBusinessUnitManager = Set("plannedEffortRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// The number of minutes the manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager
        {
            get => plannedEffortRequesterManager;
            set => plannedEffortRequesterManager = Set("plannedEffortRequesterManager", value);
        }

        /// <summary>
        /// The number of minutes the owner of the service of the related to the workflow is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner
        {
            get => plannedEffortServiceOwner;
            set => plannedEffortServiceOwner = Set("plannedEffortServiceOwner", value);
        }

        /// <summary>
        /// The number of minutes the workflow manager is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortWorkflowManager")]
        public long? PlannedEffortWorkflowManager
        {
            get => plannedEffortWorkflowManager;
            set => plannedEffortWorkflowManager = Set("plannedEffortWorkflowManager", value);
        }

        /// <summary>
        /// Default: <c>false</c> - Whether the provider indicates not to be accountable for the affected SLAs linked to the requests that are linked to the workflow of a task that was created based on the template.
        /// </summary>
        [JsonProperty("providerNotAccountable")]
        public bool? ProviderNotAccountable
        {
            get => providerNotAccountable;
            set => providerNotAccountable = Set("providerNotAccountable", value);
        }

        /// <summary>
        /// Identifier of the service instance that should be selected in the Request service instance field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requestServiceInstanceId")]
        public string? RequestServiceInstanceId
        {
            get => requestServiceInstanceId;
            set => requestServiceInstanceId = Set("requestServiceInstanceId", value);
        }

        /// <summary>
        /// Identifier of the request template that should be selected in the Request template field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => requestTemplateId;
            set => requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => requiredApprovals;
            set => requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Identifiers of the service instances of the task template.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
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
        /// A short description that needs to be copied to the Subject field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that should be selected in the Supplier field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the team that should be selected in the Team field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
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
        /// Whether a new task that is created based on the template is to be marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// Whether the completion target of tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => workHoursAre24x7;
            set => workHoursAre24x7 = Set("workHoursAre24x7", value);
        }
    }
}
