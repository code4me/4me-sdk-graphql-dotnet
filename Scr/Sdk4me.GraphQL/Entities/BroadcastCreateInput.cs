using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/broadcastcreateinput/">BroadcastCreateInput</see> object.
    /// </summary>
    public class BroadcastCreateInput : PropertyChangeSet
    {
        private string? body;
        private string? clientMutationId;
        private List<string>? customerIds;
        private bool? disabled;
        private string? emailTemplateId;
        private DateTime? endAt;
        private string? message;
        private BroadcastMessageType messageType;
        private List<string>? organizationIds;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private string? requestId;
        private List<string>? serviceInstanceIds;
        private List<string>? siteIds;
        private List<string>? skillPoolIds;
        private List<string>? slaIds;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private string? subject;
        private List<string>? teamIds;
        private string? timeZone;
        private BroadcastVisibility? visibility;

        /// <summary>
        /// The body for the email broadcast.
        /// </summary>
        [JsonProperty("body")]
        public string? Body
        {
            get => body;
            set => body = Set("body", value);
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
        /// The customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        [JsonProperty("customerIds")]
        public List<string>? CustomerIds
        {
            get => customerIds;
            set => customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// Whether the message should not be broadcasted.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The id of the email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        [JsonProperty("emailTemplateId")]
        public string? EmailTemplateId
        {
            get => emailTemplateId;
            set => emailTemplateId = Set("emailTemplateId", value);
        }

        /// <summary>
        /// The end date and time of the broadcast. This field is left empty when the message is to be broadcasted until the Disabled box is checked. (If the broadcast should end at midnight at the end of a day, specify 12:00am or 24:00.)
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// Message that is to be broadcasted in the language of the account.
        /// </summary>
        [JsonProperty("message")]
        public string? Message
        {
            get => message;
            set => message = Set("message", value);
        }

        /// <summary>
        /// The appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.
        /// </summary>
        [JsonProperty("messageType"), Sdk4meField(IsRequiredForMutation = true)]
        public BroadcastMessageType MessageType
        {
            get => messageType;
            set => messageType = Set("messageType", value);
        }

        /// <summary>
        /// The ids of the organizations, to which people belong, that need to see the broadcast.
        /// </summary>
        [JsonProperty("organizationIds")]
        public List<string>? OrganizationIds
        {
            get => organizationIds;
            set => organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Any additional information about the broadcast that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        [JsonProperty("remarksAttachments")]
        public List<AttachmentInput>? RemarksAttachments
        {
            get => remarksAttachments;
            set => remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The request group to which end users can subscribe when they are also affected by the issue for which the broadcast was created.
        /// </summary>
        [JsonProperty("requestId")]
        public string? RequestId
        {
            get => requestId;
            set => requestId = Set("requestId", value);
        }

        /// <summary>
        /// The service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// The ids of the sites to which people belong and that need to see the broadcast.
        /// </summary>
        [JsonProperty("siteIds")]
        public List<string>? SiteIds
        {
            get => siteIds;
            set => siteIds = Set("siteIds", value);
        }

        /// <summary>
        /// The ids of the skill pools to which people belong and that need to see the broadcast.
        /// </summary>
        [JsonProperty("skillPoolIds")]
        public List<string>? SkillPoolIds
        {
            get => skillPoolIds;
            set => skillPoolIds = Set("skillPoolIds", value);
        }

        /// <summary>
        /// The ids of the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
        /// </summary>
        [JsonProperty("slaIds")]
        public List<string>? SlaIds
        {
            get => slaIds;
            set => slaIds = Set("slaIds", value);
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
        /// The start date and time of the broadcast. (If the broadcast should start at midnight at the start of a day, specify 00:00.)
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The subject for the email broadcast.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// The teams which members need to see the broadcast. This is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        [JsonProperty("teamIds")]
        public List<string>? TeamIds
        {
            get => teamIds;
            set => teamIds = Set("teamIds", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the dates and times specified in the Start and End fields.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Defines the target audience of the broadcast.
        /// </summary>
        [JsonProperty("visibility")]
        public BroadcastVisibility? Visibility
        {
            get => visibility;
            set => visibility = Set("visibility", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastCreateInput"/> class without providing the required values.
        /// </summary>
        public BroadcastCreateInput()
        {
            messageType = default(BroadcastMessageType);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastCreateInput"/> class.
        /// </summary>
        /// <param name="messageType">The appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.</param>
        public BroadcastCreateInput(BroadcastMessageType messageType)
        {
            this.messageType = Set("messageType", messageType);
        }
    }
}
