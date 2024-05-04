using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timesheetsetting/">TimesheetSetting</see> object.
    /// </summary>
    public class TimesheetSetting : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether people of the related organizations need to be able to register time entries for the time allocations that are linked to their organizations.
        /// </summary>
        [JsonProperty("allocationTimeTracking")]
        public bool? AllocationTimeTracking { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single day than the amount of time specified in the Workday field.
        /// </summary>
        [JsonProperty("allowWorkdayOvertime")]
        public bool? AllowWorkdayOvertime { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single week than the amount of time specified in the Workweek field.
        /// </summary>
        [JsonProperty("allowWorkweekOvertime")]
        public bool? AllowWorkweekOvertime { get; internal set; }

        /// <summary>
        /// Whether the Time spent field needs to be available in requests, problems and tasks for specialists of the related organizations to specify how long they have worked on their assignments.
        /// </summary>
        [JsonProperty("assignmentTimeTracking")]
        public bool? AssignmentTimeTracking { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the timesheet settings may no longer be related to any more organizations.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        [JsonProperty("effortClasses")]
        internal NodeCollection<EffortClass>? EffortClassesCollection { get; set; }

        /// <summary>
        /// Effort classes of the timesheet setting.
        /// </summary>
        public DataList<EffortClass>? EffortClasses
        {
            get => EffortClassesCollection?.Data;
        }

        /// <summary>
        /// The name of the timesheet settings.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Whether an email notification should be sent to each person who registered fewer hours for the past week than the workweek hours.
        /// </summary>
        [JsonProperty("notifyOnIncomplete")]
        public bool? NotifyOnIncomplete { get; internal set; }

        [JsonProperty("organizations")]
        internal NodeCollection<Organization>? OrganizationsCollection { get; set; }

        /// <summary>
        /// Organizations of the timesheet setting.
        /// </summary>
        public DataList<Organization>? Organizations
        {
            get => OrganizationsCollection?.Data;
        }

        /// <summary>
        /// The minimum amount percentage of a workday that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This percentage of a workday is also the increment by which they can increase this minimum percentage of a workday.
        /// </summary>
        [JsonProperty("percentageIncrement")]
        public TimesheetSettingPercentageIncrement? PercentageIncrement { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        [JsonProperty("problemEffortClass")]
        public EffortClass? ProblemEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        [JsonProperty("projectTaskEffortClass")]
        public EffortClass? ProjectTaskEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        [JsonProperty("requestEffortClass")]
        public EffortClass? RequestEffortClass { get; internal set; }

        /// <summary>
        /// Whether the Note field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem or task.
        /// </summary>
        [JsonProperty("requireNote")]
        public bool? RequireNote { get; internal set; }

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
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        [JsonProperty("taskEffortClass")]
        public EffortClass? TaskEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        [JsonProperty("timeAllocationEffortClass")]
        public EffortClass? TimeAllocationEffortClass { get; internal set; }

        /// <summary>
        /// The minimum amount of time that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This amount of time is also the increment by which they can increase this minimum amount of time.
        /// </summary>
        [JsonProperty("timeIncrement")]
        public TimesheetSettingTimeIncrement? TimeIncrement { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked need to register their time in hours and minutes, or as a percentage of a workday.
        /// </summary>
        [JsonProperty("unit")]
        public TimesheetSettingUnit? Unit { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The duration of a workday in minutes.
        /// </summary>
        [JsonProperty("workday")]
        public long? Workday { get; internal set; }

        /// <summary>
        /// The duration of a workweek in minutes.
        /// </summary>
        [JsonProperty("workweek")]
        public long? Workweek { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(EffortClassesCollection?.GetQueryPageInfo("effortClasses", depth + 1));
            retval.AddRange(OrganizationsCollection?.GetQueryPageInfo("organizations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            EffortClasses?.AddRange((data as TimesheetSetting)?.EffortClasses);
            Organizations?.AddRange((data as TimesheetSetting)?.Organizations);
        }
    }
}
