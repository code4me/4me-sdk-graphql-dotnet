using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productbacklog/">ProductBacklog</see> object.
    /// </summary>
    public class ProductBacklog : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the product backlog.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the backlog may not be used to place items on.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        [JsonProperty("items")]
        internal NodeCollection<ProductBacklogItem>? ItemsCollection { get; set; }

        /// <summary>
        /// Items on this backlog.
        /// </summary>
        public DataList<ProductBacklogItem>? Items
        {
            get => ItemsCollection?.Data;
        }

        /// <summary>
        /// Name of the product backlog.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// Person responsible for maximizing the value of the work done based on this product backlog.
        /// </summary>
        [JsonProperty("productOwner")]
        public Person? ProductOwner { get; internal set; }

        [JsonProperty("scrumWorkspaces")]
        internal NodeCollection<ScrumWorkspace>? ScrumWorkspacesCollection { get; set; }

        /// <summary>
        /// Scrum workspaces taking items from this backlog when planning their sprints.
        /// </summary>
        public DataList<ScrumWorkspace>? ScrumWorkspaces
        {
            get => ScrumWorkspacesCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(ItemsCollection?.GetQueryPageInfo("items", depth + 1));
            retval.AddRange(ScrumWorkspacesCollection?.GetQueryPageInfo("scrumWorkspaces", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as ProductBacklog)?.DescriptionAttachments);
            Items?.AddRange((data as ProductBacklog)?.Items);
            ScrumWorkspaces?.AddRange((data as ProductBacklog)?.ScrumWorkspaces);
        }
    }
}
