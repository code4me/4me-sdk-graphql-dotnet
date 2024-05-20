using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectcategoryupdatepayload/">ProjectCategoryUpdatePayload</see> object.
    /// </summary>
    public class ProjectCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectCategory"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ProjectCategory? ProjectCategory { get; internal set; }
    }
}
