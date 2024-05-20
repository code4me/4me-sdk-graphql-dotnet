using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timeentry/">TimeEntry</see> object.
    /// </summary>
    public class TimeEntry : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. Some examples of activities are standard requests, a high impact incident or a request for information. The Activity ID can be used to support integrations between the billing system of the service provider and the 4me account in which the activities are performed.
        /// </summary>
        [JsonProperty("activityID")]
        public string? ActivityID { get; internal set; }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider. The agreement ID can be used to support integrations between the billing system of the service provider and the 4me account in which the activities are performed.
        /// </summary>
        [JsonProperty("agreementID")]
        public string? AgreementID { get; internal set; }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        [JsonProperty("assignment")]
        public IHasTimeEntries? Assignment { get; internal set; }

        /// <summary>
        /// For a Time and Materials activity the charge is calculated by multiplying the time spent by the charge rate of the person’s who spent the time based on the selected effort class. For a Fixed Price activity the charge is the amount defined for the fixed price activity in the service offering (of the billable SLA related to the request).
        /// </summary>
        [JsonProperty("charge")]
        public decimal? Charge { get; internal set; }

        /// <summary>
        /// <br>The currency of the charge field value of the time entry.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("chargeCurrency")]
        public string? ChargeCurrency { get; internal set; }

        /// <summary>
        /// Shows the charging rate per hour and is defined by the effort class that was selected when the person registered the time entry.
        /// </summary>
        [JsonProperty("chargeRate")]
        public decimal? ChargeRate { get; internal set; }

        /// <summary>
        /// The charge type field defines how the activity must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeType")]
        public ServiceOfferingChargeType? ChargeType { get; internal set; }

        /// <summary>
        /// Whether the time entry should be considered a correction for a time entry that was registered for a date that has already been locked.
        /// </summary>
        [JsonProperty("correction")]
        public bool? Correction { get; internal set; }

        /// <summary>
        /// The cost of the time entry. It is calculated by multiplying the time spent by the cost per hour of the person who spent the time.
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; internal set; }

        /// <summary>
        /// <br>The currency of the cost value of the time entry.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("costCurrency")]
        public string? CostCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization for which the time was spent.
        /// </summary>
        [JsonProperty("customer"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The date on which the time was spent.
        /// </summary>
        [JsonProperty("date"), Sdk4meField(IsDefaultQueryProperty = true)]
#if NET6_0_OR_GREATER
        public DateOnly? Date { get; internal set; }
#else
        public DateTime? Date { get; internal set; }
#endif

        /// <summary>
        /// Automatically checked after the time entry has been deleted. The data of a deleted time entry that is older than 3 months can no longer be retrieved.
        /// </summary>
        [JsonProperty("deleted"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? Deleted { get; internal set; }

        /// <summary>
        /// A short description of the time spent. This field is available and required only when the Description required box is checked in the selected time allocation.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The note the time entry is linked to.
        /// </summary>
        [JsonProperty("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// The organization to which the person was linked when the time entry was created.
        /// </summary>
        [JsonProperty("organization"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Organization? Organization { get; internal set; }

        /// <summary>
        /// The person who spent the time.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The Rate ID is the unique identifier by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider. The effort class represents the type of effort that was performed when working on an activity. Some examples of effort classes are 'Billable - Normal Hours', 'Billable overtime', 'Non Billable' or 'Senior System Engineer'. The Rate ID can be used to support integrations between the billing system of the service provider and the 4me account in which the activities are performed. In the billing system the Rate IDs will be linked to the rates that have been agreed on in the service contract.
        /// </summary>
        [JsonProperty("rateID")]
        public string? RateID { get; internal set; }

        /// <summary>
        /// The service for which the time was spent.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Service? Service { get; internal set; }

        /// <summary>
        /// The service instance for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        [JsonProperty("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// The service level agreement for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        [JsonProperty("serviceLevelAgreement")]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The start time of the work.
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// Team the person of the time entry was a member of while the work was performed.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        [JsonProperty("timeAllocation")]
        public TimeAllocation? TimeAllocation { get; internal set; }

        /// <summary>
        /// The number of minutes that was spent on the selected time allocation. The number of minutes is allowed to be negative only when the correction field is set to <c>true</c>.
        /// </summary>
        [JsonProperty("timeSpent"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? TimeSpent { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
