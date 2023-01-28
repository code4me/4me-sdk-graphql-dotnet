namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/standardservicerequestactivityidinput/">StandardServiceRequestActivityIDInput</see> object.
    /// </summary>
    public class StandardServiceRequestActivityIDInput : PropertyChangeSet
    {
        private string? id;
        private string? standardServiceRequestId;
        private string? activityID;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be `null`.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The standard service request identifier for which a billing identifier is provided.
        /// </summary>
        [JsonProperty("standardServiceRequestId")]
        public string? StandardServiceRequestId
        {
            get => standardServiceRequestId;
            set => standardServiceRequestId = Set("standardServiceRequestId", value);
        }

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("activityID")]
        public string? ActivityID
        {
            get => activityID;
            set => activityID = Set("activityID", value);
        }
    }
}
