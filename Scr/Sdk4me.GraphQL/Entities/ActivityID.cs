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
        /// Represents the activityID for high incidents. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("high")]
        public string? High { get; internal set; }

        /// <summary>
        /// Represents the activityID for low incidents. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("low")]
        public string? Low { get; internal set; }

        /// <summary>
        /// Represents the activityID for medium incidents. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("medium")]
        public string? Medium { get; internal set; }

        /// <summary>
        /// Represents the activityID for RFCs. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfc")]
        public string? Rfc { get; internal set; }

        /// <summary>
        /// Represents the activityID for RFIs. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("rfi")]
        public string? Rfi { get; internal set; }

        /// <summary>
        /// Represents the activityID for top incidents. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("top")]
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
