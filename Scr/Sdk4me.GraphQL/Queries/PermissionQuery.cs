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
    }
}
