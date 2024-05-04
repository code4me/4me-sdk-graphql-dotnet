using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projectphaseinput/">ProjectPhaseInput</see> object.
    /// </summary>
    public class ProjectPhaseInput : PropertyChangeSet
    {
        private string? id;
        private string? name;
        private long? position;

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
        /// The name of the project phase.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the project phase takes when it is presented in the project's Gantt chart.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }
    }
}
