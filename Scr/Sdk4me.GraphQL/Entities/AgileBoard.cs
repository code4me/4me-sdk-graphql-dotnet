using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/agileboard/">AgileBoard</see> object.
    /// </summary>
    public class AgileBoard : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        [JsonProperty("columns")]
        internal NodeCollection<AgileBoardColumn>? ColumnsCollection { get; set; }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        public DataList<AgileBoardColumn>? Columns
        {
            get => ColumnsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Scrum sprint the agile board is currently linked to.
        /// </summary>
        [JsonProperty("currentSprint")]
        public Sprint? CurrentSprint { get; internal set; }

        [JsonProperty("customerRepresentativeSlas")]
        internal NodeCollection<ServiceLevelAgreement>? CustomerRepresentativeSlasCollection { get; set; }

        /// <summary>
        /// Customer representatives of these service level agreements can view this board in Self Service.
        /// </summary>
        public DataList<ServiceLevelAgreement>? CustomerRepresentativeSlas
        {
            get => CustomerRepresentativeSlasCollection?.Data;
        }

        /// <summary>
        /// Description of the agile board.
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
        /// Whether the board may not be used to place items on.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Manager of the agile board.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// Name of the agile board.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

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
            retval.AddRange(ColumnsCollection?.GetQueryPageInfo("columns", depth + 1));
            retval.AddRange(CustomerRepresentativeSlasCollection?.GetQueryPageInfo("customerRepresentativeSlas", depth + 1));
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Columns?.AddRange((data as AgileBoard)?.Columns);
            CustomerRepresentativeSlas?.AddRange((data as AgileBoard)?.CustomerRepresentativeSlas);
            DescriptionAttachments?.AddRange((data as AgileBoard)?.DescriptionAttachments);
        }
    }
}
