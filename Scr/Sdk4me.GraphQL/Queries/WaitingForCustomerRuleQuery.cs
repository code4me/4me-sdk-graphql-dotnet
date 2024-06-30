namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WaitingForCustomerRule">WaitingForCustomerRule</see> query.
    /// </summary>
    public class WaitingForCustomerRuleQuery : Query<WaitingForCustomerRuleQuery, WaitingForCustomerRuleField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new waiting for customer rule query instance.
        /// </summary>
        public WaitingForCustomerRuleQuery()
            : base("", typeof(WaitingForCustomerRule), true)
        {
        }
    }
}
