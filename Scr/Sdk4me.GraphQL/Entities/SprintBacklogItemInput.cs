using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/sprintbacklogiteminput/">SprintBacklogItemInput</see> object.
    /// </summary>
    public class SprintBacklogItemInput : PropertyChangeSet
    {
        private bool? done;
        private long? estimate;
        private string? id;
        private bool? planned;
        private long? position;
        private string? recordId;

        /// <summary>
        /// Whether this item has been completed in this sprint. <c>null</c> indicates the item was removed from the sprint.
        /// </summary>
        [JsonProperty("done")]
        public bool? Done
        {
            get => done;
            set => done = Set("done", value);
        }

        /// <summary>
        /// Estimate of the relative size of this item on the sprint backlog.
        /// </summary>
        [JsonProperty("estimate")]
        public long? Estimate
        {
            get => estimate;
            set => estimate = Set("estimate", value);
        }

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Whether this item was part of the sprint backlog when the sprint was started.
        /// </summary>
        [JsonProperty("planned")]
        public bool? Planned
        {
            get => planned;
            set => planned = Set("planned", value);
        }

        /// <summary>
        /// Position of the record on the sprint backlog.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// Identifier of the record on the sprint backlog.
        /// </summary>
        [JsonProperty("recordId")]
        public string? RecordId
        {
            get => recordId;
            set => recordId = Set("recordId", value);
        }
    }
}
