namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclassrate/">EffortClassRate</see> object.
    /// </summary>
    public class EffortClassRate : Node
    {
        /// <summary>
        /// The date and time at which the effort class rate was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The effort class of the effort class rate.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The rate per hour for the effort class.
        /// </summary>
        [JsonProperty("rate")]
        public decimal? Rate { get; internal set; }

        /// <summary>
        /// <br>The currency of the rate per hour for the effort class.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/ratecurrency/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("rateCurrency")]
        public string? RateCurrency { get; internal set; }

        /// <summary>
        /// The service offering of the effort class rate.
        /// </summary>
        [JsonProperty("serviceOffering")]
        public ServiceOffering? ServiceOffering { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the effort class rate. If the effort class rate has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt")]
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
