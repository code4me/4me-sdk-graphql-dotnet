using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/address/">Address</see> object.
    /// </summary>
    public class Address : Node
    {
        /// <summary>
        /// The city name.
        /// </summary>
        [JsonProperty("city"), Sdk4meField(true)]
        public string? City { get; internal set; }

        /// <summary>
        /// The country name.
        /// </summary>
        [JsonProperty("country"), Sdk4meField(true)]
        public string? Country { get; internal set; }

        /// <summary>
        /// The Integration field is a hidden checkbox that can be set to <c>true</c> using this API or the Import functionality. When checked, the address is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration"), Sdk4meField(true)]
        public bool? Integration { get; internal set; }

        /// <summary>
        /// The Label of the address details.
        /// </summary>
        [JsonProperty("label"), Sdk4meField(true)]
        public AddressLabel? Label { get; internal set; }

        /// <summary>
        /// The state name.
        /// </summary>
        [JsonProperty("state"), Sdk4meField(true)]
        public string? State { get; internal set; }

        /// <summary>
        /// The address lines.
        /// </summary>
        [JsonProperty("address"), Sdk4meField(true)]
        public string? Street { get; internal set; }

        /// <summary>
        /// The zip code.
        /// </summary>
        [JsonProperty("zip"), Sdk4meField(true)]
        public string? Zip { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
