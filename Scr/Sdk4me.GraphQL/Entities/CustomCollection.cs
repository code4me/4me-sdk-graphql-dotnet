using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollection/">CustomCollection</see> object.
    /// </summary>
    public class CustomCollection : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        [JsonProperty("collectionElements")]
        internal NodeCollection<CustomCollectionElement>? CollectionElementsCollection { get; set; }

        /// <summary>
        /// Elements of this custom collection.
        /// </summary>
        public DataList<CustomCollectionElement>? CollectionElements
        {
            get => CollectionElementsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the collection.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the collection may not be used for new custom views.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Name of the collection.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// This reference can be used to link the collection to an element using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; internal set; }

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
        /// UI extension that is linked to the collection.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CollectionElementsCollection?.GetQueryPageInfo("collectionElements", depth + 1));
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CollectionElements?.AddRange((data as CustomCollection)?.CollectionElements);
            DescriptionAttachments?.AddRange((data as CustomCollection)?.DescriptionAttachments);
        }
    }
}
