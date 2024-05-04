using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/watch/">Watch</see> object.
    /// </summary>
    public class Watch : Node
    {
        /// <summary>
        /// The person who added this watch.
        /// </summary>
        [JsonProperty("addedBy")]
        public Person? AddedBy { get; internal set; }

        /// <summary>
        /// The date and time at which the watch was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who is watching the record.
        /// </summary>
        [JsonProperty("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the watch. If the watch has had no updates it contains the <c>createdAt</c> value.
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
