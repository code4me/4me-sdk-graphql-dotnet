namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/asyncquery/">AsyncQuery</see> object.
    /// </summary>
    public class AsyncQuery
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to the status `completed`.
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of errors encountered during the execution.
        /// </summary>
        [JsonProperty("errorCount"), Sdk4meField(true)]
        public long? ErrorCount { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(true)]
        public string? ID { get; internal set; }

        /// <summary>
        /// The person or application who created the async query.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(true)]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The number of affected records.
        /// </summary>
        [JsonProperty("resultCount"), Sdk4meField(true)]
        public long? ResultCount { get; internal set; }

        /// <summary>
        /// Expiring link to the JSON result of the async query. It is available once the async query execution has been completed.
        /// </summary>
        [JsonProperty("resultUrl"), Sdk4meField(true)]
        public string? ResultUrl { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to status `in_progress`.
        /// </summary>
        [JsonProperty("startedAt"), Sdk4meField(true)]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the async query.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public AsyncQueryStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the async query. If the async query has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }
    }
}
