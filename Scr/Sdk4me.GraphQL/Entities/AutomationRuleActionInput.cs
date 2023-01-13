namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/automationruleactioninput/">AutomationRuleActionInput</see> object.
    /// </summary>
    public class AutomationRuleActionInput : PropertyChangeSet
    {
        private string? name;
        private string? datavalue;

        /// <summary>
        /// Name of the action.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// <br>The action that should be executed when the condition of the automation rule is met. Takes one of the following forms:</br>
        /// <br>* `update &lt;record&gt; set &lt;field&gt; = &lt;value&gt;`</br>
        /// <br>* `update &lt;record&gt; add &lt;value&gt; to &lt;collection&gt;`</br>
        /// <br>* `update &lt;record&gt; remove &lt;value&gt; from &lt;collection&gt;`</br>
        /// <br>* `update &lt;record&gt; clear &lt;collection&gt;`</br>
        /// <br>* `update &lt;record&gt; add note '&lt;value&gt;'`</br>
        /// <br>* `after &lt;delay&gt; trigger '&lt;rule&gt;'`</br>
        /// <br>* `call webhook '&lt;webhook&gt;' with payload '&lt;payload&gt;'`</br>
        /// <br>When the action operates on the current record, leave out `update &lt;record&gt;`.</br>
        /// <br>Examples:</br>
        /// <br>* `update workflow set manager = my_person`</br>
        /// <br>* `add my_ci to cis`</br>
        /// <br>* `add note 'Hello {{@my_person}}'`</br>
        /// <br>* `after 30.minutes trigger 'My Delay Rule'`</br>
        /// <br>* `call webhook 'My Webhook' with payload 'my_payload'`</br>.
        /// </summary>
        [JsonProperty("value")]
        public string? Value
        {
            get => datavalue;
            set => datavalue = Set("value", value);
        }
    }
}
