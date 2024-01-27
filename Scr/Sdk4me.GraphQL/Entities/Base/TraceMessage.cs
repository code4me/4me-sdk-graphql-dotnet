namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A Sdk4me log message.
    /// </summary>
    public class TraceMessage
    {
        /// <summary>
        /// Gets or sets the HTTP method.
        /// </summary>
        [JsonProperty("id")]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method.
        /// </summary>
        [JsonProperty("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request URI.
        /// </summary>
        [JsonProperty("uri")]
        public string? URI { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request content.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Gets or sets the 4me account identifier.
        /// </summary>
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }

        /// <summary>
        /// Gets or sets the request response time in milliseconds.
        /// </summary>
        [JsonProperty("response_time_in_ms")]
        public long? ResponseTimeInMilliseconds { get; set; }

        /// <summary>
        /// Returns a JSON formatted string that represents the object instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
