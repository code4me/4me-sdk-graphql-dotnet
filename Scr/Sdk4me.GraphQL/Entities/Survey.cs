namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/survey/">Survey</see> object.
    /// </summary>
    public class Survey : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Content shown to respondents on completion of the survey.
        /// </summary>
        [JsonProperty("completion")]
        public string? Completion { get; internal set; }

        [JsonProperty("completionAttachments")]
        internal NodeCollection<Attachment>? CompletionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Completion field.
        /// </summary>
        public DataList<Attachment>? CompletionAttachments
        {
            get => CompletionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the survey may not be used.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Introduction content of the survey.
        /// </summary>
        [JsonProperty("introduction")]
        public string? Introduction { get; internal set; }

        [JsonProperty("introductionAttachments")]
        internal NodeCollection<Attachment>? IntroductionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Introduction field.
        /// </summary>
        public DataList<Attachment>? IntroductionAttachments
        {
            get => IntroductionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Name of the survey.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        [JsonProperty("questions")]
        internal NodeCollection<SurveyQuestion>? QuestionsCollection { get; set; }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        public DataList<SurveyQuestion>? Questions
        {
            get => QuestionsCollection?.Data;
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

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CompletionAttachmentsCollection?.GetQueryPageInfo("completionAttachments", depth + 1));
            retval.AddRange(IntroductionAttachmentsCollection?.GetQueryPageInfo("introductionAttachments", depth + 1));
            retval.AddRange(QuestionsCollection?.GetQueryPageInfo("questions", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CompletionAttachments?.AddRange((data as Survey)?.CompletionAttachments);
            IntroductionAttachments?.AddRange((data as Survey)?.IntroductionAttachments);
            Questions?.AddRange((data as Survey)?.Questions);
            Translations?.AddRange((data as Survey)?.Translations);
        }
    }
}
