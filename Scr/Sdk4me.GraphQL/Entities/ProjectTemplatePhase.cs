namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttemplatephase/">ProjectTemplatePhase</see> object.
    /// </summary>
    public class ProjectTemplatePhase : Node
    {
        /// <summary>
        /// The date and time at which the project template's phase was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The name of the project template's phase.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the phase takes when it is presented in its project template.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the project template's phase. If the phase has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
