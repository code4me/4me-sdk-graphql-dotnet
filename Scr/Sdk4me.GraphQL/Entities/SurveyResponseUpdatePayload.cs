using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/surveyresponseupdatepayload/">SurveyResponseUpdatePayload</see> object.
    /// </summary>
    public class SurveyResponseUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("surveyResponse"), Sdk4meField(IsDefaultQueryProperty = true)]
        public SurveyResponse? SurveyResponse { get; internal set; }
    }
}
