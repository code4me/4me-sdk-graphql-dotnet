using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingscopeinput/">AppOfferingScopeInput</see> object.
    /// </summary>
    public class AppOfferingScopeInput : PropertyChangeSet
    {
        private List<string>? actions;
        private List<string>? conditions;
        private ScopeEffect? effect;
        private string? id;

        /// <summary>
        /// Actions this scope applies to.
        /// </summary>
        [JsonProperty("actions")]
        public List<string>? Actions
        {
            get => actions;
            set => actions = Set("actions", value);
        }

        /// <summary>
        /// Conditions for this scope.
        /// </summary>
        [JsonProperty("conditions")]
        public List<string>? Conditions
        {
            get => conditions;
            set => conditions = Set("conditions", value);
        }

        /// <summary>
        /// Whether this scope allows or prevents access.
        /// </summary>
        [JsonProperty("effect")]
        public ScopeEffect? Effect
        {
            get => effect;
            set => effect = Set("effect", value);
        }

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }
    }
}
