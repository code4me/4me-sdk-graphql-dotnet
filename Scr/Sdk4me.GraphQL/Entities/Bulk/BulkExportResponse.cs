using Newtonsoft.Json;
using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The 4me export status.
    /// </summary>
    public class BulkExportResponse
    {
        /// <summary>
        /// The state.
        /// </summary>
        [JsonProperty("state")]
        public ImportExportStatus State { get; internal set; } = ImportExportStatus.Queued;

        /// <summary>
        /// The type or types.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; internal set; }

        /// <summary>
        /// The progress.
        /// </summary>
        [JsonProperty("line")]
        public string? Line { get; internal set; }

        /// <summary>
        /// The download URL.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; internal set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; internal set; }

        /// <summary>
        /// Additional failure rate limit failure information.
        /// </summary>
        [JsonProperty("rate_limit_exceeded")]
        public string? RateLimitExceeded {  get; internal set; }

        /// <summary>
        /// A link to the export log file.
        /// </summary>
        [JsonProperty("logfile")]
        public string? LogFile { get; internal set; }
    }
}
