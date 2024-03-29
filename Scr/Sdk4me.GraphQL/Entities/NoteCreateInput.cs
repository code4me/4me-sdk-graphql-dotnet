﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/notecreateinput/">NoteCreateInput</see> object.
    /// </summary>
    public class NoteCreateInput : PropertyChangeSet
    {
        private List<AttachmentInput>? attachments;
        private string? clientMutationId;
        private bool? @event;
        private string? ownerId;
        private bool? suppressNoteAddedNotifications;
        private string? text;

        /// <summary>
        /// The attachments used in the <c>note</c> field.
        /// </summary>
        [JsonProperty("attachments")]
        public List<AttachmentInput>? Attachments
        {
            get => attachments;
            set => attachments = Set("attachments", value);
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
        /// Whether the note should be visible only for people who have the Auditor, Specialist or Account Administrator role of the account. Internal notes are only available for Requests.
        /// </summary>
        [JsonProperty("internal")]
        public bool? Internal
        {
            get => @event;
            set => @event = Set("internal", value);
        }

        /// <summary>
        /// The record that the note should be added to.
        /// </summary>
        [JsonProperty("ownerId")]
        public string? OwnerId
        {
            get => ownerId;
            set => ownerId = Set("ownerId", value);
        }

        /// <summary>
        /// Whether Note Added notifications for this note should be suppressed.
        /// </summary>
        [JsonProperty("suppressNoteAddedNotifications")]
        public bool? SuppressNoteAddedNotifications
        {
            get => suppressNoteAddedNotifications;
            set => suppressNoteAddedNotifications = Set("suppressNoteAddedNotifications", value);
        }

        /// <summary>
        /// Text of the note.
        /// </summary>
        [JsonProperty("text")]
        public string? Text
        {
            get => text;
            set => text = Set("text", value);
        }
    }
}
