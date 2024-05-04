using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/agileboardcolumninput/">AgileBoardColumnInput</see> object.
    /// </summary>
    public class AgileBoardColumnInput : PropertyChangeSet
    {
        private AgileBoardColumnActionType? actionType;
        private bool? clearMember;
        private AgileBoardColumnDialogType? dialogType;
        private string? id;
        private string? memberId;
        private string? name;
        private long? position;
        private long? removeAfter;
        private string? teamId;
        private long? wipLimit;

        /// <summary>
        /// Type of action to perform when an item is added to this column.
        /// </summary>
        [JsonProperty("actionType")]
        public AgileBoardColumnActionType? ActionType
        {
            get => actionType;
            set => actionType = Set("actionType", value);
        }

        /// <summary>
        /// Should the assigned person field of an item be cleared when the action type is <c>assign</c> and the item is added to this column?
        /// </summary>
        [JsonProperty("clearMember")]
        public bool? ClearMember
        {
            get => clearMember;
            set => clearMember = Set("clearMember", value);
        }

        /// <summary>
        /// Type of dialog to open when an item is added to this column.
        /// </summary>
        [JsonProperty("dialogType")]
        public AgileBoardColumnDialogType? DialogType
        {
            get => dialogType;
            set => dialogType = Set("dialogType", value);
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

        /// <summary>
        /// Identifier of the person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// Name of the column.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Relative position of the column.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// Items in this column will be removed from the board if they are not explicitly moved in this many days.
        /// </summary>
        [JsonProperty("removeAfter")]
        public long? RemoveAfter
        {
            get => removeAfter;
            set => removeAfter = Set("removeAfter", value);
        }

        /// <summary>
        /// Identifier of the team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// Work-in-progress limit for the column.
        /// </summary>
        [JsonProperty("wipLimit")]
        public long? WipLimit
        {
            get => wipLimit;
            set => wipLimit = Set("wipLimit", value);
        }
    }
}
