namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/surveycreatepayload/">SurveyCreatePayload</see> object.
    /// </summary>
    public class SurveyCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("survey"), Sdk4meField(true)]
        public Survey? Survey { get; internal set; }
    }
}
