using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/waitingforcustomerfollowup/">WaitingForCustomerFollowUp</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUp : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Auto-complete when the final waiting for customer follow-up notification is sent.
        /// </summary>
        [JsonProperty("autoComplete")]
        public bool? AutoComplete { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the waiting for customer follow-up may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        [JsonProperty("waitingForCustomerRules")]
        internal NodeCollection<WaitingForCustomerRule>? WaitingForCustomerRulesCollection { get; set; }

        /// <summary>
        /// Rules of the waiting for customer follow-up.
        /// </summary>
        public DataList<WaitingForCustomerRule>? WaitingForCustomerRules
        {
            get => WaitingForCustomerRulesCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(WaitingForCustomerRulesCollection?.GetQueryPageInfo("waitingForCustomerRules", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            WaitingForCustomerRules?.AddRange((data as WaitingForCustomerFollowUp)?.WaitingForCustomerRules);
        }
    }
}
