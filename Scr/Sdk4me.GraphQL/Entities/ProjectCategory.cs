namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectcategory/">ProjectCategory</see> object.
    /// </summary>
    public class ProjectCategory : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// A very short description of the project category, for example "More than 200 workdays or $200K".
        /// </summary>
        [JsonProperty("description"), Sdk4meField(true)]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the project category may not be related to any more projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Any additional information about the project category that might prove useful, especially for project managers when they need to decide which project category to select for a project.
        /// </summary>
        [JsonProperty("information")]
        public string? Information { get; internal set; }

        [JsonProperty("informationAttachments")]
        internal NodeCollection<Attachment>? InformationAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public DataList<Attachment>? InformationAttachments
        {
            get => InformationAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The name of the project category. Ideally the name of a project category consists of a single word, such as "Large".
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the project category takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// The Reference field is automatically set to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the project category to a project using the 4me REST API or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference"), Sdk4meField(true)]
        public string? Reference { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(InformationAttachmentsCollection?.GetQueryPageInfo("informationAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            InformationAttachments?.AddRange((data as ProjectCategory)?.InformationAttachments);
        }
    }
}
