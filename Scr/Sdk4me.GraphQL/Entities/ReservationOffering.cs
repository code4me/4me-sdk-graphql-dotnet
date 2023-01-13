namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservationoffering/">ReservationOffering</see> object.
    /// </summary>
    public class ReservationOffering : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether it is allowed to create recurrent reservations for this offering.
        /// </summary>
        [JsonProperty("allowRepeat")]
        public bool? AllowRepeat { get; internal set; }

        /// <summary>
        /// The Calendar field is used to select the calendar that defines the hours during which the configuration items can be made available for temporary use.
        /// </summary>
        [JsonProperty("calendar")]
        public Calendar? Calendar { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// The Configuration items field is used to select the configuration items that people, who are covered by an active service level agreement for the related service instance, should be able to reserve for temporary use after the reservation offering is related to a request template of the category ‘Reservation’.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the reservation offering may not be used to register requests for reservation.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The Filters field allows filters to be selected that people, who are selecting a configuration item of the reservation offering, can use to limit the list of configuration items to only those that meet specific criteria, such as the configuration item’s product or site.
        /// </summary>
        [JsonProperty("filters")]
        public List<string>? Filters { get; internal set; }

        /// <summary>
        /// The Initial status field is used to specify whether a reservation that was requested using the reservation offering is immediately confirmed after it has been submitted, or that an action (such as an approval) is still required before it can be confirmed.
        /// </summary>
        [JsonProperty("initialStatus")]
        public ReservationStatus? InitialStatus { get; internal set; }

        /// <summary>
        /// The Max. advance duration field is used to specify how far in the future the start of a reservation is allowed to be scheduled using the reservation offering.
        /// </summary>
        [JsonProperty("maxAdvanceDuration")]
        public long? MaxAdvanceDuration { get; internal set; }

        /// <summary>
        /// The Max. duration field is used to specify the maximum length of time for which a configuration item of the reservation offering can be reserved.
        /// </summary>
        [JsonProperty("maxDuration")]
        public long? MaxDuration { get; internal set; }

        /// <summary>
        /// The Min. advance duration field is used to specify how much advance notice is needed from the moment a reservation is requested using the reservation offering and the start of the reservation. This is typically the time needed to prepare a configuration item of the reservation offering.
        /// </summary>
        [JsonProperty("minAdvanceDuration")]
        public long? MinAdvanceDuration { get; internal set; }

        /// <summary>
        /// The Min. duration field is used to specify the minimum length of time for which a configuration item of the reservation offering can be reserved.
        /// </summary>
        [JsonProperty("minDuration")]
        public long? MinDuration { get; internal set; }

        /// <summary>
        /// The Multi-day box is checked when a reservation request that uses the reservation offering is allowed to start on one day and end on another.
        /// </summary>
        [JsonProperty("multiDay")]
        public bool? MultiDay { get; internal set; }

        /// <summary>
        /// A short description of the reservation offering.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The Preparation duration field is used to specify the amount of time needed to prepare a configuration item of the reservation offering for the next person who reserved it. People are not be able to request a reservation of a configuration item if it overlaps with the preparation duration of an existing reservation for the same configuration item.
        /// </summary>
        [JsonProperty("preparationDuration")]
        public long? PreparationDuration { get; internal set; }

        [JsonProperty("requestTemplates")]
        internal NodeCollection<RequestTemplate>? RequestTemplatesCollection { get; set; }

        /// <summary>
        /// The Request templates table field lists the request templates to which the reservation offering is linked.
        /// </summary>
        public DataList<RequestTemplate>? RequestTemplates
        {
            get => RequestTemplatesCollection?.Data;
        }

        /// <summary>
        /// The Service instance field is used to select the service instance for which people need to be covered in order to be able to make use of the reservation offering.
        /// </summary>
        [JsonProperty("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

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

        /// <summary>
        /// The Step duration field is used specify the time increments for the duration of a reservation that is requested using the reservation offering.
        /// </summary>
        [JsonProperty("stepDuration")]
        public long? StepDuration { get; internal set; }

        /// <summary>
        /// <br>The Time zone field is used to select the time zone that applies to the selected calendar.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(RequestTemplatesCollection?.GetQueryPageInfo("requestTemplates", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ConfigurationItems?.AddRange((data as ReservationOffering)?.ConfigurationItems);
            RequestTemplates?.AddRange((data as ReservationOffering)?.RequestTemplates);
        }
    }
}
