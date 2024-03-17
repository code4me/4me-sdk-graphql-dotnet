namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Tag">Tag</see> query.
    /// </summary>
    public class TagQuery : Query<TagQuery, TagField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new tag query instance.
        /// </summary>
        public TagQuery()
            : base("", typeof(Tag), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public TagQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
