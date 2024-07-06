using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Represents the results of an import operation.
    /// </summary>
    public class ImportResults
    {
        /// <summary>
        /// Gets or sets the number of created items.
        /// </summary>
        [JsonProperty("created")]
        public int Created { get; set; }

        /// <summary>
        /// Gets or sets the number of updated items.
        /// </summary>
        [JsonProperty("updated")]
        public int Updated { get; set; }

        /// <summary>
        /// Gets or sets the number of deleted items.
        /// </summary>
        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        /// <summary>
        /// Gets or sets the number of unchanged items.
        /// </summary>
        [JsonProperty("unchanged")]
        public int Unchanged { get; set; }

        /// <summary>
        /// Gets or sets the number of failures.
        /// </summary>
        [JsonProperty("failures")]
        public int Failures { get; set; }

        /// <summary>
        /// Gets or sets the number of errors.
        /// </summary>
        [JsonProperty("errors")]
        public int Errors { get; set; }
    }

}
