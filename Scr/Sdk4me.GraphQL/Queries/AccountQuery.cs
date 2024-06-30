namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The current account.
    /// </summary>
    public class AccountQuery : Query<AccountQuery, AccountField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new account query instance.
        /// </summary>
        public AccountQuery()
            : base("account", typeof(Account), false)
        {
        }

        /// <summary>
        /// The organization for which the account was prepared.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AccountQuery SelectOrganization(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
