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
        /// The account this record belongs to.
        /// </summary>
        public SyncSetQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the <c>description</c> field.
        /// </summary>
        public SyncSetQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The latest completed snapshot of this sync set.
        /// </summary>
        public SyncSetQuery SelectLastSnapshot(SnapshotQuery query)
        {
            query.FieldName = "lastSnapshot";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
