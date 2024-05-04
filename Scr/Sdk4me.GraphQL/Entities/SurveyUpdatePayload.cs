using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/surveyupdatepayload/">SurveyUpdatePayload</see> object.
    /// </summary>
    public class SurveyUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("survey"), Sdk4meField(true)]
        public Survey? Survey { get; internal set; }
    }
}
