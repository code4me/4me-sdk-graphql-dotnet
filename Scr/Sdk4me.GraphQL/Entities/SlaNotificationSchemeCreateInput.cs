namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/slanotificationschemecreateinput/">SlaNotificationSchemeCreateInput</see> object.
    /// </summary>
    public class SlaNotificationSchemeCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? disabled;
        private string? name;
        private List<SlaNotificationRuleInput>? newSlaNotificationRules;
        private string? clientMutationId;

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the service level agreement notification scheme may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the service level agreement notification scheme.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Rules of this service level agreement notification scheme.
        /// </summary>
        [JsonProperty("newSlaNotificationRules")]
        public List<SlaNotificationRuleInput>? NewSlaNotificationRules
        {
            get => newSlaNotificationRules;
            set => newSlaNotificationRules = Set("newSlaNotificationRules", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }
    }
}
