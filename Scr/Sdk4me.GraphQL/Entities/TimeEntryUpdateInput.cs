using Newtonsoft.Json;
using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/timeentryupdateinput/">TimeEntryUpdateInput</see> object.
    /// </summary>
    public class TimeEntryUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? correction;
        private string? customerId;
#if NET6_0_OR_GREATER
        private DateOnly? date;
#else
        private DateTime? date;
#endif
        private bool? deleted;
        private string? description;
        private string? effortClassId;
        private string? id;
        private string? noteId;
        private string? organizationId;
        private string? personId;
        private string? serviceId;
        private string? source;
        private string? sourceID;
        private DateTime? startedAt;
        private string? teamId;
        private string? timeAllocationId;
        private long? timeSpent;

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
        /// Whether the time entry should be considered a correction for a time entry that was registered for a date that has already been locked.
        /// </summary>
        [JsonProperty("correction")]
        public bool? Correction
        {
            get => correction;
            set => correction = Set("correction", value);
        }

        /// <summary>
        /// Identifier of the organization for which the time was spent.
        /// </summary>
        [JsonProperty("customerId")]
        public string? CustomerId
        {
            get => customerId;
            set => customerId = Set("customerId", value);
        }

        /// <summary>
        /// The date on which the time was spent.
        /// </summary>
        [JsonProperty("date")]
#if NET6_0_OR_GREATER
        public DateOnly? Date
#else
        public DateTime? Date
#endif
        {
            get => date;
            set => date = Set("date", value);
        }

        /// <summary>
        /// Automatically checked after the time entry has been deleted. The data of a deleted time entry that is older than 3 months can no longer be retrieved.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted
        {
            get => deleted;
            set => deleted = Set("deleted", value);
        }

        /// <summary>
        /// A short description of the time spent. This field is available and required only when the Description required box is checked in the selected time allocation.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Identifier of the effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the note the time entry is linked to.
        /// </summary>
        [JsonProperty("noteId")]
        public string? NoteId
        {
            get => noteId;
            set => noteId = Set("noteId", value);
        }

        /// <summary>
        /// Identifier of the organization to which the person was linked when the time entry was created.
        /// </summary>
        [JsonProperty("organizationId")]
        public string? OrganizationId
        {
            get => organizationId;
            set => organizationId = Set("organizationId", value);
        }

        /// <summary>
        /// Identifier of the person who spent the time.
        /// </summary>
        [JsonProperty("personId")]
        public string? PersonId
        {
            get => personId;
            set => personId = Set("personId", value);
        }

        /// <summary>
        /// Identifier of the service for which the time was spent.
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
        /// The start time of the work.
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTime? StartedAt
        {
            get => startedAt;
            set => startedAt = Set("startedAt", value);
        }

        /// <summary>
        /// Identifier of the team the person of the time entry was a member of while the work was performed.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// Identifier of the time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        [JsonProperty("timeAllocationId")]
        public string? TimeAllocationId
        {
            get => timeAllocationId;
            set => timeAllocationId = Set("timeAllocationId", value);
        }

        /// <summary>
        /// The number of minutes that was spent on the selected time allocation. The number of minutes is allowed to be negative only when the correction field is set to <c>true</c>.
        /// </summary>
        [JsonProperty("timeSpent")]
        public long? TimeSpent
        {
            get => timeSpent;
            set => timeSpent = Set("timeSpent", value);
        }
    }
}
