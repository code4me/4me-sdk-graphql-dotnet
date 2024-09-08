using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/activityid/">ActivityID</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class ActivityID : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// Represents the activityID for cases. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("case"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Case { get; internal set; }

        /// <summary>
        /// Represents the activityID for high incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("high"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? High { get; internal set; }

        /// <summary>
        /// Represents the activityID for low incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("low"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Low { get; internal set; }

        /// <summary>
        /// Represents the activityID for medium incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("medium"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Medium { get; internal set; }

        /// <summary>
        /// Represents the activityID for RFCs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfc"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Rfc { get; internal set; }

        /// <summary>
        /// Represents the activityID for RFIs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfi"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Rfi { get; internal set; }

        /// <summary>
        /// Represents the activityID for top incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("top"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Top { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
