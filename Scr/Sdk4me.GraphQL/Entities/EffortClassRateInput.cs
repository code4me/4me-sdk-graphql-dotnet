namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/effortclassrateinput/">EffortClassRateInput</see> object.
    /// </summary>
    public class EffortClassRateInput : PropertyChangeSet
    {
        private string? id;
        private string? effortClassId;
        private decimal? rate;
        private string? rateCurrency;

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
        /// The effort class for which the rate is provided.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The rate per hour for the effort class.
        /// </summary>
        [JsonProperty("rate")]
        public decimal? Rate
        {
            get => rate;
            set => rate = Set("rate", value);
        }

        /// <summary>
        /// <br>The currency for the rate per hour for the effort class.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateCurrency")]
        public string? RateCurrency
        {
            get => rateCurrency;
            set => rateCurrency = Set("rateCurrency", value);
        }
    }
}
