using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/workflowtypecreateinput/">WorkflowTypeCreateInput</see> object.
    /// </summary>
    public class WorkflowTypeCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? description;
        private bool? disabled;
        private string? information;
        private List<AttachmentInput>? informationAttachments;
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
        /// Very short description of the workflow type, for example "More than 200 workdays or $200K".
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Whether the workflow type may not be related to any more workflows.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the workflow type that might prove useful, especially for workflow managers when they need to decide which workflow type to select for a workflow.
        /// </summary>
        [JsonProperty("information")]
        public string? Information
        {
            get => information;
            set => information = Set("information", value);
        }

        /// <summary>
        /// The attachments used in the <c>information</c> field.
        /// </summary>
        [JsonProperty("informationAttachments")]
        public List<AttachmentInput>? InformationAttachments
        {
            get => informationAttachments;
            set => informationAttachments = Set("informationAttachments", value);
        }

        /// <summary>
        /// The name of the workflow type. Ideally the name of a workflow type consists of a single word, such as "Large".
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the workflow type takes when it is displayed in a sorted list.
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
        /// Initializes a new instance of the <see cref="WorkflowTypeCreateInput"/> class without providing the required values.
        /// </summary>
        public WorkflowTypeCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeCreateInput"/> class.
        /// </summary>
        /// <param name="name">The name of the workflow type. Ideally the name of a workflow type consists of a single word, such as "Large".</param>
        public WorkflowTypeCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
