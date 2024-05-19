using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/automationruleactioninput/">AutomationRuleActionInput</see> object.
    /// </summary>
    public class AutomationRuleActionInput : PropertyChangeSet
    {
        private string name;
        private string value;

        /// <summary>
        /// Name of the action.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// <br>The action that should be executed when the condition of the automation rule is met. Takes one of the following forms:</br>
        /// <br>• <c>update &lt;record&gt; set &lt;field&gt; = &lt;value&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; add &lt;value&gt; to &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; remove &lt;value&gt; from &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; clear &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; add note '&lt;value&gt;'</c></br>
        /// <br>• <c>after &lt;delay&gt; trigger '&lt;rule&gt;'</c></br>
        /// <br>• <c>call webhook '&lt;webhook&gt;' with payload '&lt;payload&gt;'</c></br>
        /// <br></br>
        /// <br>When the action operates on the current record, leave out <c>update &lt;record&gt;</c>.</br>
        /// <br></br>
        /// <br>Examples:</br>
        /// <br>• <c>update workflow set manager = my_person</c></br>
        /// <br>• <c>add my_ci to cis</c></br>
        /// <br>• <c>add note 'Hello {{@my_person}}'</c></br>
        /// <br>• <c>after 30.minutes trigger 'My Delay Rule'</c></br>
        /// <br>• <c>call webhook 'My Webhook' with payload 'my_payload'</c></br>
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get => value;
            set => this.value = Set("value", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleActionInput"/> class without providing the required values.
        /// </summary>
        public AutomationRuleActionInput()
        {
            name = string.Empty;
            value = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleActionInput"/> class.
        /// </summary>
        /// <param name="name">Name of the action.</param>
        /// <param name="value">
        /// <br>The action that should be executed when the condition of the automation rule is met. Takes one of the following forms:</br>
        /// <br>• <c>update &lt;record&gt; set &lt;field&gt; = &lt;value&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; add &lt;value&gt; to &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; remove &lt;value&gt; from &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; clear &lt;collection&gt;</c></br>
        /// <br>• <c>update &lt;record&gt; add note '&lt;value&gt;'</c></br>
        /// <br>• <c>after &lt;delay&gt; trigger '&lt;rule&gt;'</c></br>
        /// <br>• <c>call webhook '&lt;webhook&gt;' with payload '&lt;payload&gt;'</c></br>
        /// <br></br>
        /// <br>When the action operates on the current record, leave out <c>update &lt;record&gt;</c>.</br>
        /// <br></br>
        /// <br>Examples:</br>
        /// <br>• <c>update workflow set manager = my_person</c></br>
        /// <br>• <c>add my_ci to cis</c></br>
        /// <br>• <c>add note 'Hello {{@my_person}}'</c></br>
        /// <br>• <c>after 30.minutes trigger 'My Delay Rule'</c></br>
        /// <br>• <c>call webhook 'My Webhook' with payload 'my_payload'</c></br>
        /// </param>
        public AutomationRuleActionInput(string name, string value)
        {
            this.name = Set("name", name);
            this.value = Set("value", value);
        }
    }
}
