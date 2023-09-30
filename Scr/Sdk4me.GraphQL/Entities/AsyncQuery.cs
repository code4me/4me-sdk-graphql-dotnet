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
        /// The date and time at which the async query was set to the status <c>completed</c>.
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of errors encountered during the execution.
        /// </summary>
        [JsonProperty("errorCount"), Sdk4meField(true)]
        public long? ErrorCount { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
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
        /// The date and time at which the async query was set to status <c>in_progress</c>.
        /// </summary>
        [JsonProperty("startedAt"), Sdk4meField(true)]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// <br>The current status of the async query. Valid values are:</br>
        /// <br>• <c>queued</c>: The async query has been received and is waiting to be executed.</br>
        /// <br>• <c>in_progress</c>: The async query is being executed.</br>
        /// <br>• <c>completed</c>: The async query execution has been completed. Results can be found by downloading the <c>result_url</c>.</br>
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public AsyncQueryStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }
    }
}
