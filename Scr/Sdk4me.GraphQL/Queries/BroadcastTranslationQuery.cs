namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="BroadcastTranslation">BroadcastTranslation</see> query.
    /// </summary>
    public class BroadcastTranslationQuery : Query<BroadcastTranslationQuery, BroadcastTranslationField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new broadcast translation query instance.
        /// </summary>
        public BroadcastTranslationQuery()
            : base("", typeof(BroadcastTranslation), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the <c>message</c> field.
        /// </summary>
        public BroadcastTranslationQuery SelectMessageAttachments(AttachmentQuery query)
        {
            query.FieldName = "messageAttachments";
            return Select(query);
        }
    }
}
