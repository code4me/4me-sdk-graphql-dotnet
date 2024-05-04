using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projectrisklevelupdateinput/">ProjectRiskLevelUpdateInput</see> object.
    /// </summary>
    public class ProjectRiskLevelUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? description;
        private bool? disabled;
        private string? id;
        private string? information;
        private string? name;
        private long? position;
        private string? source;
        private string? sourceID;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// A very short description of the project risk level, for example "Risk of Failure is Significant".
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Whether the project risk level may not be related to any more projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Any additional information about the project risk level that might prove useful, especially for project managers when they need to decide which project risk level to select for a project.
        /// </summary>
        [JsonProperty("information")]
        public string? Information
        {
            get => information;
            set => information = Set("information", value);
        }

        /// <summary>
        /// The name of the project risk level. Ideally the name of a project risk level consists of a single word, such as "Significant".
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the project risk level takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }
    }
}
