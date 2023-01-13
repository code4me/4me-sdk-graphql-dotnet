namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/surveyresponse/">SurveyResponse</see> object.
    /// </summary>
    public class SurveyResponse : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("answers")]
        internal NodeCollection<SurveyAnswer>? AnswersCollection { get; set; }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        public DataList<SurveyAnswer>? Answers
        {
            get => AnswersCollection?.Data;
        }

        /// <summary>
        /// Whether the respondent completed the survey.
        /// </summary>
        [JsonProperty("completed")]
        public bool? Completed { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Rating calculated based on the answers.
        /// </summary>
        [JsonProperty("rating"), Sdk4meField(true)]
        public string? Rating { get; internal set; }

        /// <summary>
        /// How the individual answers were combined to calculate the rating.
        /// </summary>
        [JsonProperty("ratingCalculation"), Sdk4meField(true)]
        public JToken? RatingCalculation { get; internal set; }

        /// <summary>
        /// Time this response was submitted.
        /// </summary>
        [JsonProperty("respondedAt")]
        public DateTime? RespondedAt { get; internal set; }

        /// <summary>
        /// Service this response is about.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("slas")]
        internal NodeCollection<ServiceLevelAgreement>? SlasCollection { get; set; }

        /// <summary>
        /// Service level agreements of this survey response.
        /// </summary>
        public DataList<ServiceLevelAgreement>? Slas
        {
            get => SlasCollection?.Data;
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
        /// Survey this response is for.
        /// </summary>
        [JsonProperty("survey"), Sdk4meField(true)]
        public Survey? Survey { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AnswersCollection?.GetQueryPageInfo("answers", depth + 1));
            retval.AddRange(SlasCollection?.GetQueryPageInfo("slas", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Answers?.AddRange((data as SurveyResponse)?.Answers);
            Slas?.AddRange((data as SurveyResponse)?.Slas);
        }
    }
}
