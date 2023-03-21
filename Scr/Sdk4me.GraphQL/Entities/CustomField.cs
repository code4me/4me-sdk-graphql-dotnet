namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customfield/">CustomField</see> object.
    /// </summary>
    public class CustomField : Node
    {
        /// <summary>
        /// <br>Value of the field.</br>
        /// <br>• For <c>select</c> fields the value is the HTML <c>value</c> defined for the value (not the value shown to the user).</br>
        /// <br>• For <c>...-suggest</c> fields the value is the node ID of the selected record.</br>
        /// <br>• For <c>custom-suggest</c> fields the value is the node ID of the selected record. When multiple records are selected the value is an array of node IDs.</br>
        /// </summary>
        [JsonProperty("value"), Sdk4meField(true)]
        public JToken? Value { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
