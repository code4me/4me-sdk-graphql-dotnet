using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclassrateid/">EffortClassRateID</see> object.
    /// </summary>
    public class EffortClassRateID : Node
    {
        /// <summary>
        /// The date and time at which the rateID was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The effort class for which a rateID is provided.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rateID")]
        public string? RateID { get; internal set; }

        /// <summary>
        /// The date and time at which the rateID was updated.
        /// </summary>
        [JsonProperty("updatedAt")]
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
