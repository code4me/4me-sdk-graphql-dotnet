namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/syncset/">SyncSet</see> object.
    /// </summary>
    public class SyncSet : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the sync set.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the <c>description</c> field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The latest completed snapshot of this sync set.
        /// </summary>
        [JsonProperty("lastSnapshot")]
        public Snapshot? LastSnapshot { get; internal set; }

        /// <summary>
        /// The name of the sync set.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// Record types included in the sync set. The types match the values supported for the <see href="https://developer.4me.com/v1/import/#parameters"><c>type</c> parameter of CSV import</see>.
        /// </summary>
        [JsonProperty("resolvedTypes")]
        public List<string>? ResolvedTypes { get; internal set; }

        [JsonProperty("selectedRecords")]
        internal NodeCollection<Record>? SelectedRecordsCollection { get; set; }

        /// <summary>
        /// Individual records selected to be included in the sync set.
        /// </summary>
        public DataList<Record>? SelectedRecords
        {
            get => SelectedRecordsCollection?.Data;
        }

        /// <summary>
        /// Record types for which all records are included in the sync set. The types match the values supported for the <see href="https://developer.4me.com/v1/import/#parameters"><c>type</c> parameter of CSV import</see>.
        /// </summary>
        [JsonProperty("types")]
        public List<string>? Types { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(SelectedRecordsCollection?.GetQueryPageInfo("selectedRecords", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as SyncSet)?.DescriptionAttachments);
            SelectedRecords?.AddRange((data as SyncSet)?.SelectedRecords);
        }
    }
}
