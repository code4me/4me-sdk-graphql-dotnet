namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Archive records.
    /// </summary>
    public class ArchiveQuery : Query<ArchiveQuery, ArchiveField, ArchiveView, ArchiveOrderField>
    {
        /// <summary>
        /// Initialize a new archive query instance.
        /// </summary>
        public ArchiveQuery()
            : base("archive", typeof(Archive), true)
        {
        }

        /// <summary>
        /// Initialize a new archive query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the archive.</param>
        public ArchiveQuery(string id)
            : base("Archive", id, typeof(Archive), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ArchiveQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// </summary>
        public ArchiveQuery SelectArchived(HasLifeCycleStateQuery query)
        {
            query.FieldName = "archived";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who archived the record.
        /// </summary>
        public ArchiveQuery SelectArchivedBy(PersonQuery query)
        {
            query.FieldName = "archivedBy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
