namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/problemupdatepayload/">ProblemUpdatePayload</see> object.
    /// </summary>
    public class ProblemUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("problem"), Sdk4meField(true)]
        public Problem? Problem { get; internal set; }
    }
}
