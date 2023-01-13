namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeallocation/">TimeAllocation</see> object.
    /// </summary>
    public class TimeAllocation : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.
        /// </summary>
        [JsonProperty("customerCategory")]
        public TimeAllocationCustomerCategory? CustomerCategory { get; internal set; }

        [JsonProperty("customers")]
        internal NodeCollection<Organization>? CustomersCollection { get; set; }

        /// <summary>
        /// Customer organizations of the time allocation.
        /// </summary>
        public DataList<Organization>? Customers
        {
            get => CustomersCollection?.Data;
        }

        /// <summary>
        /// Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.
        /// </summary>
        [JsonProperty("descriptionCategory")]
        public TimeAllocationDescriptionCategory? DescriptionCategory { get; internal set; }

        /// <summary>
        /// Whether the time allocation may no longer be related to any more organizations.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Which group to include the time allocation in.
        /// </summary>
        [JsonProperty("group"), Sdk4meField(true)]
        public string? Group { get; internal set; }

        /// <summary>
        /// The name of the time allocation.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        [JsonProperty("organizations")]
        internal NodeCollection<Organization>? OrganizationsCollection { get; set; }

        /// <summary>
        /// Organizations of the time allocation.
        /// </summary>
        public DataList<Organization>? Organizations
        {
            get => OrganizationsCollection?.Data;
        }

        /// <summary>
        /// Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.
        /// </summary>
        [JsonProperty("serviceCategory")]
        public TimeAllocationServiceCategory? ServiceCategory { get; internal set; }

        [JsonProperty("services")]
        internal NodeCollection<Service>? ServicesCollection { get; set; }

        /// <summary>
        /// Services of the time allocation.
        /// </summary>
        public DataList<Service>? Services
        {
            get => ServicesCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomersCollection?.GetQueryPageInfo("customers", depth + 1));
            retval.AddRange(OrganizationsCollection?.GetQueryPageInfo("organizations", depth + 1));
            retval.AddRange(ServicesCollection?.GetQueryPageInfo("services", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Customers?.AddRange((data as TimeAllocation)?.Customers);
            Organizations?.AddRange((data as TimeAllocation)?.Organizations);
            Services?.AddRange((data as TimeAllocation)?.Services);
            Translations?.AddRange((data as TimeAllocation)?.Translations);
        }
    }
}
