namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/timeallocationupdateinput/">TimeAllocationUpdateInput</see> object.
    /// </summary>
    public class TimeAllocationUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private TimeAllocationCustomerCategory? customerCategory;
        private List<string>? customerIds;
        private TimeAllocationDescriptionCategory? descriptionCategory;
        private bool? disabled;
        private string? effortClassId;
        private string? group;
        private string? id;
        private string? name;
        private List<string>? organizationIds;
        private TimeAllocationServiceCategory? serviceCategory;
        private List<string>? serviceIds;
        private string? source;
        private string? sourceID;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.
        /// </summary>
        [JsonProperty("customerCategory")]
        public TimeAllocationCustomerCategory? CustomerCategory
        {
            get => customerCategory;
            set => customerCategory = Set("customerCategory", value);
        }

        /// <summary>
        /// Identifiers of the customer organizations of the time allocation.
        /// </summary>
        [JsonProperty("customerIds")]
        public List<string>? CustomerIds
        {
            get => customerIds;
            set => customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.
        /// </summary>
        [JsonProperty("descriptionCategory")]
        public TimeAllocationDescriptionCategory? DescriptionCategory
        {
            get => descriptionCategory;
            set => descriptionCategory = Set("descriptionCategory", value);
        }

        /// <summary>
        /// Whether the time allocation may no longer be related to any more organizations.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Which group to include the time allocation in.
        /// </summary>
        [JsonProperty("group")]
        public string? Group
        {
            get => group;
            set => group = Set("group", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The name of the time allocation.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Identifiers of the organizations of the time allocation.
        /// </summary>
        [JsonProperty("organizationIds")]
        public List<string>? OrganizationIds
        {
            get => organizationIds;
            set => organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.
        /// </summary>
        [JsonProperty("serviceCategory")]
        public TimeAllocationServiceCategory? ServiceCategory
        {
            get => serviceCategory;
            set => serviceCategory = Set("serviceCategory", value);
        }

        /// <summary>
        /// Identifiers of the services of the time allocation.
        /// </summary>
        [JsonProperty("serviceIds")]
        public List<string>? ServiceIds
        {
            get => serviceIds;
            set => serviceIds = Set("serviceIds", value);
        }

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
    }
}
