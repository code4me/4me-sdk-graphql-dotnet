namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/timesheetsettingupdateinput/">TimesheetSettingUpdateInput</see> object.
    /// </summary>
    public class TimesheetSettingUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? allocationTimeTracking;
        private bool? allowWorkdayOvertime;
        private bool? allowWorkweekOvertime;
        private bool? assignmentTimeTracking;
        private bool? disabled;
        private string? name;
        private bool? notifyOnIncomplete;
        private TimesheetSettingPercentageIncrement? percentageIncrement;
        private string? problemEffortClassId;
        private string? projectTaskEffortClassId;
        private string? requestEffortClassId;
        private bool? requireNote;
        private string? taskEffortClassId;
        private string? timeAllocationEffortClassId;
        private TimesheetSettingTimeIncrement? timeIncrement;
        private TimesheetSettingUnit? unit;
        private long? workday;
        private long? workweek;
        private List<string>? effortClassIds;
        private List<string>? organizationIds;
        private string? id;
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
        /// Whether people of the related organizations need to be able to register time entries for the time allocations that are linked to their organizations.
        /// </summary>
        [JsonProperty("allocationTimeTracking")]
        public bool? AllocationTimeTracking
        {
            get => allocationTimeTracking;
            set => allocationTimeTracking = Set("allocationTimeTracking", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single day than the amount of time specified in the Workday field.
        /// </summary>
        [JsonProperty("allowWorkdayOvertime")]
        public bool? AllowWorkdayOvertime
        {
            get => allowWorkdayOvertime;
            set => allowWorkdayOvertime = Set("allowWorkdayOvertime", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single week than the amount of time specified in the Workweek field.
        /// </summary>
        [JsonProperty("allowWorkweekOvertime")]
        public bool? AllowWorkweekOvertime
        {
            get => allowWorkweekOvertime;
            set => allowWorkweekOvertime = Set("allowWorkweekOvertime", value);
        }

        /// <summary>
        /// Whether the Time spent field needs to be available in requests, problems and tasks for specialists of the related organizations to specify how long they have worked on their assignments.
        /// </summary>
        [JsonProperty("assignmentTimeTracking")]
        public bool? AssignmentTimeTracking
        {
            get => assignmentTimeTracking;
            set => assignmentTimeTracking = Set("assignmentTimeTracking", value);
        }

        /// <summary>
        /// Whether the timesheet settings may no longer be related to any more organizations.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the timesheet settings.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Whether an email notification should be sent to each person who registered fewer hours for the past week than the workweek hours.
        /// </summary>
        [JsonProperty("notifyOnIncomplete")]
        public bool? NotifyOnIncomplete
        {
            get => notifyOnIncomplete;
            set => notifyOnIncomplete = Set("notifyOnIncomplete", value);
        }

        /// <summary>
        /// The minimum amount percentage of a workday that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This percentage of a workday is also the increment by which they can increase this minimum percentage of a workday.
        /// </summary>
        [JsonProperty("percentageIncrement")]
        public TimesheetSettingPercentageIncrement? PercentageIncrement
        {
            get => percentageIncrement;
            set => percentageIncrement = Set("percentageIncrement", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        [JsonProperty("problemEffortClassId")]
        public string? ProblemEffortClassId
        {
            get => problemEffortClassId;
            set => problemEffortClassId = Set("problemEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        [JsonProperty("projectTaskEffortClassId")]
        public string? ProjectTaskEffortClassId
        {
            get => projectTaskEffortClassId;
            set => projectTaskEffortClassId = Set("projectTaskEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        [JsonProperty("requestEffortClassId")]
        public string? RequestEffortClassId
        {
            get => requestEffortClassId;
            set => requestEffortClassId = Set("requestEffortClassId", value);
        }

        /// <summary>
        /// Whether the Note field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem or task.
        /// </summary>
        [JsonProperty("requireNote")]
        public bool? RequireNote
        {
            get => requireNote;
            set => requireNote = Set("requireNote", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        [JsonProperty("taskEffortClassId")]
        public string? TaskEffortClassId
        {
            get => taskEffortClassId;
            set => taskEffortClassId = Set("taskEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        [JsonProperty("timeAllocationEffortClassId")]
        public string? TimeAllocationEffortClassId
        {
            get => timeAllocationEffortClassId;
            set => timeAllocationEffortClassId = Set("timeAllocationEffortClassId", value);
        }

        /// <summary>
        /// The minimum amount of time that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This amount of time is also the increment by which they can increase this minimum amount of time.
        /// </summary>
        [JsonProperty("timeIncrement")]
        public TimesheetSettingTimeIncrement? TimeIncrement
        {
            get => timeIncrement;
            set => timeIncrement = Set("timeIncrement", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked need to register their time in hours and minutes, or as a percentage of a workday.
        /// </summary>
        [JsonProperty("unit")]
        public TimesheetSettingUnit? Unit
        {
            get => unit;
            set => unit = Set("unit", value);
        }

        /// <summary>
        /// The duration of a workday in minutes.
        /// </summary>
        [JsonProperty("workday")]
        public long? Workday
        {
            get => workday;
            set => workday = Set("workday", value);
        }

        /// <summary>
        /// The duration of a workweek in minutes.
        /// </summary>
        [JsonProperty("workweek")]
        public long? Workweek
        {
            get => workweek;
            set => workweek = Set("workweek", value);
        }

        /// <summary>
        /// Identifiers of effort classes of the timesheet setting.
        /// </summary>
        [JsonProperty("effortClassIds")]
        public List<string>? EffortClassIds
        {
            get => effortClassIds;
            set => effortClassIds = Set("effortClassIds", value);
        }

        /// <summary>
        /// Identifiers of organizations of the timesheet setting.
        /// </summary>
        [JsonProperty("organizationIds")]
        public List<string>? OrganizationIds
        {
            get => organizationIds;
            set => organizationIds = Set("organizationIds", value);
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
