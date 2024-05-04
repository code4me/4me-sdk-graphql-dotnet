using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/teamcreateinput/">TeamCreateInput</see> object.
    /// </summary>
    public class TeamCreateInput : PropertyChangeSet
    {
        private string? agileBoardId;
        private bool? autoAssign;
        private string? clientMutationId;
        private string? configurationManagerId;
        private string? coordinatorId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private bool? disabled;
        private string? inboundEmailLocalPart;
        private string? managerId;
        private List<string>? memberIds;
        private string? name;
        private string? pictureUri;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private string? source;
        private string? sourceID;
        private string? timeZone;
        private string? uiExtensionId;
        private string? workHoursId;

        /// <summary>
        /// Used to automatically link records to the agile board when they are assigned to the team.
        /// </summary>
        [JsonProperty("agileBoardId")]
        public string? AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Whether requests are auto-assigned to a team member.
        /// </summary>
        [JsonProperty("autoAssign")]
        public bool? AutoAssign
        {
            get => autoAssign;
            set => autoAssign = Set("autoAssign", value);
        }

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
        /// The person who maintains the information about the configuration items that the team supports.
        /// </summary>
        [JsonProperty("configurationManagerId")]
        public string? ConfigurationManagerId
        {
            get => configurationManagerId;
            set => configurationManagerId = Set("configurationManagerId", value);
        }

        /// <summary>
        /// The current team coordinator for the team. Only members of the team can be selected in this field.
        /// </summary>
        [JsonProperty("coordinatorId")]
        public string? CoordinatorId
        {
            get => coordinatorId;
            set => coordinatorId = Set("coordinatorId", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// Whether the team may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Used to specify an email address for the team. When an email is sent to this email address, a new request gets generated and assigned to the team.
        /// </summary>
        [JsonProperty("inboundEmailLocalPart")]
        public string? InboundEmailLocalPart
        {
            get => inboundEmailLocalPart;
            set => inboundEmailLocalPart = Set("inboundEmailLocalPart", value);
        }

        /// <summary>
        /// The manager or supervisor of the team. This person is able to maintain the information about the team. The manager of a team does not need to be a member of the team.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// People that are linked as member to the team.
        /// </summary>
        [JsonProperty("memberIds")]
        public List<string>? MemberIds
        {
            get => memberIds;
            set => memberIds = Set("memberIds", value);
        }

        /// <summary>
        /// The name of the team.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Any additional information about the team that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [JsonProperty("remarksAttachments")]
        public List<AttachmentInput>? RemarksAttachments
        {
            get => remarksAttachments;
            set => remarksAttachments = Set("remarksAttachments", value);
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
        /// <br>The time zone that applies to the selected work hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// The calendar that defines the work hours during which the team is available for work on all types of assignments.
        /// </summary>
        [JsonProperty("workHoursId")]
        public string? WorkHoursId
        {
            get => workHoursId;
            set => workHoursId = Set("workHoursId", value);
        }
    }
}
