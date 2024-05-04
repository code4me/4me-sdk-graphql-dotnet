using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/activityidinput/">ActivityIDInput</see> object.
    /// </summary>
    public class ActivityIDInput : PropertyChangeSet
    {
        private string? @case;
        private string? high;
        private string? low;
        private string? medium;
        private string? rfc;
        private string? rfi;
        private string? top;

        /// <summary>
        /// Represents the activityID for cases. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("case")]
        public string? Case
        {
            get => @case;
            set => @case = Set("case", value);
        }

        /// <summary>
        /// Represents the activityID for high incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("high")]
        public string? High
        {
            get => high;
            set => high = Set("high", value);
        }

        /// <summary>
        /// Represents the activityID for low incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("low")]
        public string? Low
        {
            get => low;
            set => low = Set("low", value);
        }

        /// <summary>
        /// Represents the activityID for medium incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("medium")]
        public string? Medium
        {
            get => medium;
            set => medium = Set("medium", value);
        }

        /// <summary>
        /// Represents the activityID for RFCs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfc")]
        public string? Rfc
        {
            get => rfc;
            set => rfc = Set("rfc", value);
        }

        /// <summary>
        /// Represents the activityID for RFIs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfi")]
        public string? Rfi
        {
            get => rfi;
            set => rfi = Set("rfi", value);
        }

        /// <summary>
        /// Represents the activityID for top incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("top")]
        public string? Top
        {
            get => top;
            set => top = Set("top", value);
        }
    }
}
