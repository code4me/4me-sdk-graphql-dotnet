namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/customfieldinput/">CustomFieldInput</see> object.
    /// </summary>
    public class CustomFieldInput : PropertyChangeSet
    {
        private string? id;
        private JToken? datavalue;

        /// <summary>
        /// Identifier of the field as defined for the user interface Extension.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// <br>Value for the field.</br>
        /// <br> * For `select` fields the value is the HTML `value` defined for the value (not the value shown to the user).</br>
        /// <br> * For `...-suggest` fields the value is the node identifier of the selected record.</br>
        /// <br> * For `custom-suggest` fields the value is the node identifier of the selected record. When multiple records are to be selected the value should be an array of node IDs.</br>.
        /// </summary>
        [JsonProperty("value")]
        public JToken? Value
        {
            get => datavalue;
            set => datavalue = Set("value", value);
        }
    }
}
