namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/skillpoolupdatepayload/">SkillPoolUpdatePayload</see> object.
    /// </summary>
    public class SkillPoolUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("skillPool"), Sdk4meField(true)]
        public SkillPool? SkillPool { get; internal set; }
    }
}
