using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/skillpool/">SkillPool</see> object.
    /// </summary>
    public class SkillPool : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The skill pool's estimated total cost per work hour for the service provider organization.
        /// </summary>
        [JsonProperty("costPerHour")]
        public decimal? CostPerHour { get; internal set; }

        /// <summary>
        /// <br>The currency of the cost per hour value of this skill pool.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("costPerHourCurrency")]
        public string? CostPerHourCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the skill pool may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        [JsonProperty("effortClasses")]
        internal NodeCollection<EffortClass>? EffortClassesCollection { get; set; }

        /// <summary>
        /// Effort classes linked to the skill pool.
        /// </summary>
        public DataList<EffortClass>? EffortClasses
        {
            get => EffortClassesCollection?.Data;
        }

        /// <summary>
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        [JsonProperty("members")]
        internal NodeCollection<Person>? MembersCollection { get; set; }

        /// <summary>
        /// People linked as a member to the skill pool.
        /// </summary>
        public DataList<Person>? Members
        {
            get => MembersCollection?.Data;
        }

        /// <summary>
        /// The name of the skill pool.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// Any additional information about the skill pool that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks { get; internal set; }

        [JsonProperty("remarksAttachments")]
        internal NodeCollection<Attachment>? RemarksAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public DataList<Attachment>? RemarksAttachments
        {
            get => RemarksAttachmentsCollection?.Data;
        }

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
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(EffortClassesCollection?.GetQueryPageInfo("effortClasses", depth + 1));
            retval.AddRange(MembersCollection?.GetQueryPageInfo("members", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            EffortClasses?.AddRange((data as SkillPool)?.EffortClasses);
            Members?.AddRange((data as SkillPool)?.Members);
            RemarksAttachments?.AddRange((data as SkillPool)?.RemarksAttachments);
        }
    }
}
