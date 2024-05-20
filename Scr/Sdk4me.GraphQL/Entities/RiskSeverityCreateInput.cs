﻿using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/riskseveritycreateinput/">RiskSeverityCreateInput</see> object.
    /// </summary>
    public class RiskSeverityCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? description;
        private bool? disabled;
        private string? information;
        private string name;
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
        /// A very short description of the risk severity, for example "Risk is Significant".
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Whether the risk severity may not be related to any more risks.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the risk severity that might prove useful, especially for risk managers when they need to decide which severity to select for a risk.
        /// </summary>
        [JsonProperty("information")]
        public string? Information
        {
            get => information;
            set => information = Set("information", value);
        }

        /// <summary>
        /// The name of the risk severity. Ideally the name of a risk severity consists of a single word, such as "High".
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the risk severity takes when it is displayed in a sorted list.
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

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityCreateInput"/> class without providing the required values.
        /// </summary>
        public RiskSeverityCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityCreateInput"/> class.
        /// </summary>
        /// <param name="name">The name of the risk severity. Ideally the name of a risk severity consists of a single word, such as "High".</param>
        public RiskSeverityCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
