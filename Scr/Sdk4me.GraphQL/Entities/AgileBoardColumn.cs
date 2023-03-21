namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/agileboardcolumn/">AgileBoardColumn</see> object.
    /// </summary>
    public class AgileBoardColumn : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Type of action to perform when an item is added to this column.
        /// </summary>
        [JsonProperty("actionType")]
        public AgileBoardColumnActionType? ActionType { get; internal set; }

        /// <summary>
        /// Agile board the column is part of.
        /// </summary>
        [JsonProperty("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Type of dialog to open when an item is added to this column.
        /// </summary>
        [JsonProperty("dialogType")]
        public AgileBoardColumnDialogType? DialogType { get; internal set; }

        [JsonProperty("items")]
        internal NodeCollection<AgileBoardItem>? ItemsCollection { get; set; }

        /// <summary>
        /// Items in this column.
        /// </summary>
        public DataList<AgileBoardItem>? Items
        {
            get => ItemsCollection?.Data;
        }

        /// <summary>
        /// Person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [JsonProperty("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Name of the column.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Relative position of the column.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Items in this column will be removed from the board if they are not explicitly moved in this many days.
        /// </summary>
        [JsonProperty("removeAfter")]
        public long? RemoveAfter { get; internal set; }

        /// <summary>
        /// Team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Work-in-progress limit for the column.
        /// </summary>
        [JsonProperty("wipLimit")]
        public long? WipLimit { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ItemsCollection?.GetQueryPageInfo("items", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Items?.AddRange((data as AgileBoardColumn)?.Items);
        }
    }
}
