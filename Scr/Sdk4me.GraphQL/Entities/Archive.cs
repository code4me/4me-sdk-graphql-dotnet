using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/archive/">Archive</see> object.
    /// </summary>
    public class Archive : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The archived record.
        /// </summary>
        [JsonProperty("archived"), Sdk4meField(true)]
        public IHasLifeCycleState? Archived { get; internal set; }

        /// <summary>
        /// The person who archived the record.
        /// </summary>
        [JsonProperty("archivedBy"), Sdk4meField(true)]
        public Person? ArchivedBy { get; internal set; }

        /// <summary>
        /// The date and time at which the archive was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
