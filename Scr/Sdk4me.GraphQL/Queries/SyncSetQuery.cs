namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving SyncSet records.
    /// </summary>
    public class SyncSetQuery : Query<SyncSetQuery, SyncSetField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sync set query instance.
        /// </summary>
        public SyncSetQuery()
            : base("syncSets", typeof(SyncSet), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the <c>description</c> field.
        /// </summary>
        public SyncSetQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }
    }
}
