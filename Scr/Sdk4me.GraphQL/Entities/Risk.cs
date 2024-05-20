using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/risk/">Risk</see> object.
    /// </summary>
    public class Risk : Node, IHasLifeCycleState, IHasNotes
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the risk is saved with the status "Closed".
        /// </summary>
        [JsonProperty("closedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? ClosedAt { get; internal set; }

        /// <summary>
        /// The appropriate closure reason for the risk when it has been closed.
        /// </summary>
        [JsonProperty("closureReason"), Sdk4meField(IsDefaultQueryProperty = true)]
        public RiskClosureReason? ClosureReason { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The manager of the risk. This person is able to maintain the information about the risk.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The date by which the risk should have been mitigated.
        /// </summary>
        [JsonProperty("mitigationTargetAt"), Sdk4meField(IsDefaultQueryProperty = true)]
#if NET6_0_OR_GREATER
        public DateOnly? MitigationTargetAt { get; internal set; }
#else
        public DateTime? MitigationTargetAt { get; internal set; }
#endif

        [JsonProperty("notes")]
        internal NodeCollection<Note>? NotesCollection { get; set; }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public DataList<Note>? Notes
        {
            get => NotesCollection?.Data;
        }

        [JsonProperty("organizations")]
        internal NodeCollection<Organization>? OrganizationsCollection { get; set; }

        /// <summary>
        /// Organizations linked to the risk.
        /// </summary>
        public DataList<Organization>? Organizations
        {
            get => OrganizationsCollection?.Data;
        }

        [JsonProperty("projects")]
        internal NodeCollection<Project>? ProjectsCollection { get; set; }

        /// <summary>
        /// Projects linked to the risk.
        /// </summary>
        public DataList<Project>? Projects
        {
            get => ProjectsCollection?.Data;
        }

        /// <summary>
        /// The number of minutes it took to complete this risk, which is calculated as the difference between the <c>createdAt</c> and <c>closedAt</c> values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("riskId")]
        public string? RiskId { get; internal set; }

        [JsonProperty("services")]
        internal NodeCollection<Service>? ServicesCollection { get; set; }

        /// <summary>
        /// Services linked to the risk.
        /// </summary>
        public DataList<Service>? Services
        {
            get => ServicesCollection?.Data;
        }

        /// <summary>
        /// The severity of the risk.
        /// </summary>
        [JsonProperty("severity"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Severity { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The current status of the risk.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(IsDefaultQueryProperty = true)]
        public RiskStatus? Status { get; internal set; }

        /// <summary>
        /// The subject of the risk.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(OrganizationsCollection?.GetQueryPageInfo("organizations", depth + 1));
            retval.AddRange(ProjectsCollection?.GetQueryPageInfo("projects", depth + 1));
            retval.AddRange(ServicesCollection?.GetQueryPageInfo("services", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as Risk)?.CustomFieldsAttachments);
            Notes?.AddRange((data as Risk)?.Notes);
            Organizations?.AddRange((data as Risk)?.Organizations);
            Projects?.AddRange((data as Risk)?.Projects);
            Services?.AddRange((data as Risk)?.Services);
        }
    }
}
