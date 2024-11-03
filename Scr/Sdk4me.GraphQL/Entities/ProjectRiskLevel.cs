using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectrisklevel/">ProjectRiskLevel</see> object.
    /// </summary>
    public class ProjectRiskLevel : Node
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
        /// A very short description of the project risk level, for example "Risk of Failure is Significant".
        /// </summary>
        [JsonProperty("description"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the project risk level may not be related to any more projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Any additional information about the project risk level that might prove useful, especially for project managers when they need to decide which project risk level to select for a project.
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
        /// The name of the project risk level. Ideally the name of a project risk level consists of a single word, such as "Significant".
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the project risk level takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// The Reference field is automatically set to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the project risk level to a project using the Xurrent REST API or the Xurrent Import functionality.
        /// </summary>
        [JsonProperty("reference"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(InformationAttachmentsCollection?.GetQueryPageInfo("informationAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            InformationAttachments?.AddRange((data as ProjectRiskLevel)?.InformationAttachments);
        }
    }
}
