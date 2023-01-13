namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/surveyresponseupdateinput/">SurveyResponseUpdateInput</see> object.
    /// </summary>
    public class SurveyResponseUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? completed;
        private DateTime? respondedAt;
        private string? personId;
        private string? rating;
        private JToken? ratingCalculation;
        private string? serviceId;
        private string? surveyId;
        private List<string>? slaIds;
        private List<SurveyAnswerInput>? newAnswers;
        private string? id;
        private List<string>? answersToDelete;
        private string? clientMutationId;

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
        /// Whether the respondent completed the survey.
        /// </summary>
        [JsonProperty("completed")]
        public bool? Completed
        {
            get => completed;
            set => completed = Set("completed", value);
        }

        /// <summary>
        /// Time this response was submitted.
        /// </summary>
        [JsonProperty("respondedAt")]
        public DateTime? RespondedAt
        {
            get => respondedAt;
            set => respondedAt = Set("respondedAt", value);
        }

        /// <summary>
        /// Identifier of the person who provided this response (i.e. the respondent).
        /// </summary>
        [JsonProperty("personId")]
        public string? PersonId
        {
            get => personId;
            set => personId = Set("personId", value);
        }

        /// <summary>
        /// Rating calculated based on the answers.
        /// </summary>
        [JsonProperty("rating")]
        public string? Rating
        {
            get => rating;
            set => rating = Set("rating", value);
        }

        /// <summary>
        /// How the individual answers were combined to calculate the rating.
        /// </summary>
        [JsonProperty("ratingCalculation")]
        public JToken? RatingCalculation
        {
            get => ratingCalculation;
            set => ratingCalculation = Set("ratingCalculation", value);
        }

        /// <summary>
        /// Identifier of the service this response is about.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifier of the survey this response is for.
        /// </summary>
        [JsonProperty("surveyId")]
        public string? SurveyId
        {
            get => surveyId;
            set => surveyId = Set("surveyId", value);
        }

        /// <summary>
        /// Identifiers of the service level agreements this response is for. (Ignored when supplying a personId.).
        /// </summary>
        [JsonProperty("slaIds")]
        public List<string>? SlaIds
        {
            get => slaIds;
            set => slaIds = Set("slaIds", value);
        }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        [JsonProperty("newAnswers")]
        public List<SurveyAnswerInput>? NewAnswers
        {
            get => newAnswers;
            set => newAnswers = Set("newAnswers", value);
        }

        /// <summary>
        /// The node identifier of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of answers to remove from the survey.
        /// </summary>
        [JsonProperty("answersToDelete")]
        public List<string>? AnswersToDelete
        {
            get => answersToDelete;
            set => answersToDelete = Set("answersToDelete", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }
    }
}
