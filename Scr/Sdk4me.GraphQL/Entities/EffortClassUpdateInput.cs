namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/effortclassupdateinput/">EffortClassUpdateInput</see> object.
    /// </summary>
    public class EffortClassUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private decimal? costMultiplier;
        private bool? disabled;
        private string? name;
        private long? position;
        private List<string>? timesheetSettingIds;
        private List<string>? serviceOfferingIds;
        private List<string>? skillPoolIds;
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
        /// The amount with which to multiply the cost of time entries with this effort class.
        /// </summary>
        [JsonProperty("costMultiplier")]
        public decimal? CostMultiplier
        {
            get => costMultiplier;
            set => costMultiplier = Set("costMultiplier", value);
        }

        /// <summary>
        /// Whether the effort class may no longer be related to any more timesheet settings.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the effort class.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the effort class takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// IDs of the timesheet settings of this effort class.
        /// </summary>
        [JsonProperty("timesheetSettingIds")]
        public List<string>? TimesheetSettingIds
        {
            get => timesheetSettingIds;
            set => timesheetSettingIds = Set("timesheetSettingIds", value);
        }

        /// <summary>
        /// IDs of the service offerings of this effort class.
        /// </summary>
        [JsonProperty("serviceOfferingIds")]
        public List<string>? ServiceOfferingIds
        {
            get => serviceOfferingIds;
            set => serviceOfferingIds = Set("serviceOfferingIds", value);
        }

        /// <summary>
        /// IDs of the skill pools of this effort class.
        /// </summary>
        [JsonProperty("skillPoolIds")]
        public List<string>? SkillPoolIds
        {
            get => skillPoolIds;
            set => skillPoolIds = Set("skillPoolIds", value);
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
