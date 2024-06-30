namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Attachment">Attachment</see> query.
    /// </summary>
    public class AttachmentQuery : Query<AttachmentQuery, AttachmentField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new attachment query instance.
        /// </summary>
        public AttachmentQuery()
            : base("", typeof(Attachment), true)
        {
        }
    }
}
