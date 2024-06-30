namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Contact">Contact</see> query.
    /// </summary>
    public class ContactQuery : Query<ContactQuery, ContactField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new contact query instance.
        /// </summary>
        public ContactQuery()
            : base("", typeof(Contact), true)
        {
        }
    }
}
