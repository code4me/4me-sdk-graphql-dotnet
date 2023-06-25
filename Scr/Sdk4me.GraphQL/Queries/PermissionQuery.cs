namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Permission">Permission</see> query.
    /// </summary>
    public class PermissionQuery : Query<PermissionQuery, PermissionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new permission query instance.
        /// </summary>
        public PermissionQuery()
            : base("", typeof(Permission), true)
        {
        }

        /// <summary>
        /// Account for which the person has permissions.
        /// </summary>
        public PermissionQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
