namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/trash/">Trash</see> object.
    /// </summary>
    public class Trash : Node
    {
        /// <summary>
        /// The account of the trashed record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the trash was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// </summary>
        [JsonProperty("trashed"), Sdk4meField(true)]
        public IHasLifeCycleState? Trashed { get; internal set; }

        /// <summary>
        /// The person who trashed the record.
        /// </summary>
        [JsonProperty("trashedBy"), Sdk4meField(true)]
        public Person? TrashedBy { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
