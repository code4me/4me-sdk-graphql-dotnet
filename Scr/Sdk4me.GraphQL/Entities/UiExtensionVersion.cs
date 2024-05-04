using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/uiextensionversion/">UiExtensionVersion</see> object.
    /// </summary>
    public class UiExtensionVersion : Node
    {
        /// <summary>
        /// The date and time at which this version of the UI extension was activated.
        /// </summary>
        [JsonProperty("activatedAt"), Sdk4meField(true)]
        public DateTime? ActivatedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was archived.
        /// </summary>
        [JsonProperty("archivedAt"), Sdk4meField(true)]
        public DateTime? ArchivedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The CSS stylesheet.
        /// </summary>
        [JsonProperty("css")]
        public string? Css { get; internal set; }

        /// <summary>
        /// The HTML code.
        /// </summary>
        [JsonProperty("html")]
        public string? Html { get; internal set; }

        /// <summary>
        /// The Javascript code.
        /// </summary>
        [JsonProperty("javascript")]
        public string? Javascript { get; internal set; }

        /// <summary>
        /// Indicates the location in the life-cycle.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public UiExtensionVersionStatus? Status { get; internal set; }

        /// <summary>
        /// UI extension this version belongs to.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of this version of the UI extension. If this version of the UI extension has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The version number (1..) of this version of the UI extension.
        /// </summary>
        [JsonProperty("versionNr"), Sdk4meField(true)]
        public long? VersionNr { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
