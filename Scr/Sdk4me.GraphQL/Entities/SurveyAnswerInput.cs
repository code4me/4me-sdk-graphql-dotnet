namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/surveyanswerinput/">SurveyAnswerInput</see> object.
    /// </summary>
    public class SurveyAnswerInput : PropertyChangeSet
    {
        private string? id;
        private string? questionId;
        private string? text;
        private string? rating;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the question the answer is for.
        /// </summary>
        [JsonProperty("questionId")]
        public string? QuestionId
        {
            get => questionId;
            set => questionId = Set("questionId", value);
        }

        /// <summary>
        /// Content of the answer for text questions.
        /// </summary>
        [JsonProperty("text")]
        public string? Text
        {
            get => text;
            set => text = Set("text", value);
        }

        /// <summary>
        /// Content of the answer for rating questions.
        /// </summary>
        [JsonProperty("rating")]
        public string? Rating
        {
            get => rating;
            set => rating = Set("rating", value);
        }
    }
}
