﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/customfieldinput/">CustomFieldInput</see> object.
    /// </summary>
    public class CustomFieldInput : PropertyChangeSet
    {
        private string? id;
        private JToken? datavalue;

        /// <summary>
        /// Id of the field as defined for the UI Extension.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// <br>Value for the field.</br>
        /// <br>• For <c>select</c> fields the value is the HTML <c>value</c> defined for the value (not the value shown to the user).</br>
        /// <br>• For <c>...-suggest</c> fields the value is the node ID of the selected record.</br>
        /// <br>• For <c>custom-suggest</c> fields the value is the node ID of the selected record. When multiple records are to be selected the value should be an array of node IDs.</br>
        /// </summary>
        [JsonProperty("value")]
        public JToken? Value
        {
            get => datavalue;
            set => datavalue = Set("value", value);
        }
    }
}
