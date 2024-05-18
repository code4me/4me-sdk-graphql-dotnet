using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shoparticlecategoryupdateinput/">ShopArticleCategoryUpdateInput</see> object.
    /// </summary>
    public class ShopArticleCategoryUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? fullDescription;
        private List<AttachmentInput>? fullDescriptionAttachments;
        private string id;
        private string? name;
        private string? parentId;
        private string? pictureUri;
        private string? shortDescription;
        private string? source;
        private string? sourceID;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The full description of the shop article category.
        /// </summary>
        [JsonProperty("fullDescription")]
        public string? FullDescription
        {
            get => fullDescription;
            set => fullDescription = Set("fullDescription", value);
        }

        /// <summary>
        /// The attachments used in the <c>fullDescription</c> field.
        /// </summary>
        [JsonProperty("fullDescriptionAttachments")]
        public List<AttachmentInput>? FullDescriptionAttachments
        {
            get => fullDescriptionAttachments;
            set => fullDescriptionAttachments = Set("fullDescriptionAttachments", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The display name of the shop article category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the category's parent category.
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId
        {
            get => parentId;
            set => parentId = Set("parentId", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// The shop description of the shop article category.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string? ShortDescription
        {
            get => shortDescription;
            set => shortDescription = Set("shortDescription", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCategoryUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public ShopArticleCategoryUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
