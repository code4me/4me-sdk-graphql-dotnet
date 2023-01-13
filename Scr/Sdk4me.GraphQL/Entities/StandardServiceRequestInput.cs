namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/standardservicerequestinput/">StandardServiceRequestInput</see> object.
    /// </summary>
    public class StandardServiceRequestInput : PropertyChangeSet
    {
        private string? id;
        private string? requestTemplateId;
        private long? responseTarget;
        private long? resolutionTarget;
        private string? supportHoursId;

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
        /// Identifier of the request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [JsonProperty("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => requestTemplateId;
            set => requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTarget")]
        public long? ResponseTarget
        {
            get => responseTarget;
            set => responseTarget = Set("responseTarget", value);
        }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTarget")]
        public long? ResolutionTarget
        {
            get => resolutionTarget;
            set => resolutionTarget = Set("resolutionTarget", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursId")]
        public string? SupportHoursId
        {
            get => supportHoursId;
            set => supportHoursId = Set("supportHoursId", value);
        }
    }
}
