namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclasschargeid/">EffortClassChargeID</see> object.
    /// </summary>
    public class EffortClassChargeID : Node
    {
        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("chargeID")]
        public string? ChargeID { get; internal set; }

        /// <summary>
        /// The date and time at which the chargeID was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The effort class for which a chargeID is provided.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The date and time at which the chargeID was updated.
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
