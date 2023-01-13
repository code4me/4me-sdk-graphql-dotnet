﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/surveyquestion/">SurveyQuestion</see> object.
    /// </summary>
    public class SurveyQuestion : Node
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
        /// Whether the question should not be shown to respondents.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Additional information to aid in answering the question.
        /// </summary>
        [JsonProperty("guidance")]
        public string? Guidance { get; internal set; }

        [JsonProperty("guidanceAttachments")]
        internal NodeCollection<Attachment>? GuidanceAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Guidance field.
        /// </summary>
        public DataList<Attachment>? GuidanceAttachments
        {
            get => GuidanceAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Relative position of the question.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Question to pose.
        /// </summary>
        [JsonProperty("question"), Sdk4meField(true)]
        public string? Question { get; internal set; }

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
        /// Survey the question is part of.
        /// </summary>
        [JsonProperty("survey")]
        public Survey? Survey { get; internal set; }

        /// <summary>
        /// Type of question.
        /// </summary>
        [JsonProperty("type"), Sdk4meField(true)]
        public SurveyQuestionType? Type { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Relative weight of the question.
        /// </summary>
        [JsonProperty("weight")]
        public long? Weight { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(GuidanceAttachmentsCollection?.GetQueryPageInfo("guidanceAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            GuidanceAttachments?.AddRange((data as SurveyQuestion)?.GuidanceAttachments);
        }
    }
}
