using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/translation/">Translation</see> object.
    /// </summary>
    public class Translation : Node
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
        /// Whether the translation is related to a disabled or inactive record.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The field of the record from which the translation is obtained.
        /// </summary>
        [JsonProperty("field"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Field { get; internal set; }

        /// <summary>
        /// <br>The language in which the text is specified.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/language/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("language"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Language { get; internal set; }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        [JsonProperty("owner")]
        public IHasTranslations? Owner { get; internal set; }

        /// <summary>
        /// The text of the translation.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
