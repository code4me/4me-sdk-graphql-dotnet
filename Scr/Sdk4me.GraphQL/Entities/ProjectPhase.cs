namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectphase/">ProjectPhase</see> object.
    /// </summary>
    public class ProjectPhase : Node
    {
        /// <summary>
        /// The date and time at which the project phase was set to the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the project phase was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The name of the project phase.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the project phase takes when it is presented in the project's Gantt chart.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// Indicates the date and time at which the first project task of the phase was set to a status other than `registered` or `canceled`.
        /// </summary>
        [JsonProperty("startedAt"), Sdk4meField(true)]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the project phase.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ProjectPhaseStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the project phase. If the phase has no updates it contains the `createdAt` value.
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
