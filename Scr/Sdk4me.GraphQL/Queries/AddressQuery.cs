namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Address">Address</see> query.
    /// </summary>
    public class AddressQuery : Query<AddressQuery, AddressField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new address query instance.
        /// </summary>
        public AddressQuery()
            : base("", typeof(Address), true)
        {
        }
    }
}
