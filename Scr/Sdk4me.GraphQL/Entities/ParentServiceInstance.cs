namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/parentserviceinstance/">ParentServiceInstance</see> object.
    /// </summary>
    public class ParentServiceInstance : Node
    {
        /// <summary>
        /// Indication of whether the consuming service instance is down or degraded when the service instance of the service level agreement is down or degraded.
        /// </summary>
        [JsonProperty("impactRelation"), Sdk4meField(true)]
        public ParentServiceInstanceImpactRelation? ImpactRelation { get; internal set; }

        /// <summary>
        /// Service instance consuming the service instance of the service level agreement.
        /// </summary>
        [JsonProperty("serviceInstance"), Sdk4meField(true)]
        public ServiceInstance? ServiceInstance { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
