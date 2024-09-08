using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/waitingforcustomerrule/">WaitingForCustomerRule</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class WaitingForCustomerRule : Node
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
        /// Notify the requester after the request has been waiting for a customer for this number of business days.
        /// </summary>
        [JsonProperty("nrOfBusinessDays"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? NrOfBusinessDays { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
