namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/surveyquestioninput/">SurveyQuestionInput</see> object.
    /// </summary>
    public class SurveyQuestionInput : PropertyChangeSet
    {
        private string? id;
        private bool? disabled;
        private SurveyQuestionType? type;
        private string? question;
        private string? guidance;
        private long? position;
        private bool? required;
        private long? weight;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be `null`.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Whether the question should not be shown to respondents.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Type of the question.
        /// </summary>
        [JsonProperty("type")]
        public SurveyQuestionType? Type
        {
            get => type;
            set => type = Set("type", value);
        }

        /// <summary>
        /// Question to pose.
        /// </summary>
        [JsonProperty("question")]
        public string? Question
        {
            get => question;
            set => question = Set("question", value);
        }

        /// <summary>
        /// Additional information to aid in answering the question.
        /// </summary>
        [JsonProperty("guidance")]
        public string? Guidance
        {
            get => guidance;
            set => guidance = Set("guidance", value);
        }

        /// <summary>
        /// Relative position of the question.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// Whether an answer to the question is required to completed the survey.
        /// </summary>
        [JsonProperty("required")]
        public bool? Required
        {
            get => required;
            set => required = Set("required", value);
        }

        /// <summary>
        /// Relative weight of the question.
        /// </summary>
        [JsonProperty("weight")]
        public long? Weight
        {
            get => weight;
            set => weight = Set("weight", value);
        }
    }
}
