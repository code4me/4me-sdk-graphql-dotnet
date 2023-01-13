namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="CustomField">CustomField</see> query.
    /// </summary>
    public class CustomFieldQuery : Query<CustomFieldQuery, CustomFieldField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new custom field query instance.
        /// </summary>
        public CustomFieldQuery()
            : base("", typeof(CustomField), false)
        {
        }
    }
}
