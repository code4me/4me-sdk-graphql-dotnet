using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectcategorycreatepayload/">ProjectCategoryCreatePayload</see> object.
    /// </summary>
    public class ProjectCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectCategory"), Sdk4meField(true)]
        public ProjectCategory? ProjectCategory { get; internal set; }
    }
}
