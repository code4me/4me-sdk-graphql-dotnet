using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/outofofficeperiod/">OutOfOfficePeriod</see> object.
    /// </summary>
    public class OutOfOfficePeriod : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The person who is selected as the approval delegate for the out of office period.
        /// </summary>
        [JsonProperty("approvalDelegate")]
        public Person? ApprovalDelegate { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The Effort class field is used to generate time entries for the out of office period. This field is applicable if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// End time of the out of office period.
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// The person who is out of office.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The reason of the out of office period. Required when the description category of the time allocation is required.
        /// </summary>
        [JsonProperty("reason")]
        public string? Reason { get; internal set; }

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
        /// Start time of the out of office period.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        [JsonProperty("timeAllocation")]
        public TimeAllocation? TimeAllocation { get; internal set; }

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
