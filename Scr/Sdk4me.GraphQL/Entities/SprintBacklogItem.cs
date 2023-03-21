namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/sprintbacklogitem/">SprintBacklogItem</see> object.
    /// </summary>
    public class SprintBacklogItem : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether this item has been completed in this sprint. <c>null</c> indicates the item was removed from the sprint.
        /// </summary>
        [JsonProperty("done"), Sdk4meField(true)]
        public bool? Done { get; internal set; }

        /// <summary>
        /// Estimate of the relative size of this record on the sprint backlog.
        /// </summary>
        [JsonProperty("estimate"), Sdk4meField(true)]
        public long? Estimate { get; internal set; }

        /// <summary>
        /// Whether this item was part of the sprint backlog when the sprint was started.
        /// </summary>
        [JsonProperty("planned"), Sdk4meField(true)]
        public bool? Planned { get; internal set; }

        /// <summary>
        /// Position of this record on the sprint backlog.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// Record on the sprint backlog.
        /// </summary>
        [JsonProperty("record")]
        public HasSprintBacklogItems? Record { get; internal set; }

        /// <summary>
        /// Sprint this record is part of.
        /// </summary>
        [JsonProperty("sprint"), Sdk4meField(true)]
        public Sprint? Sprint { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
