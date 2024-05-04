using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/automationruleexpression/">AutomationRuleExpression</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class AutomationRuleExpression : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => Name ?? ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// Name of the expression, which can be used to refer to the expression from the rule's conditions, actions, or from other expressions.'
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The value of the expression.
        /// </summary>
        [JsonProperty("value"), Sdk4meField(true)]
        public string? Value { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
