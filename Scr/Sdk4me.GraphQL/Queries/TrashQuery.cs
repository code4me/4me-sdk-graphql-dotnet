namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Trash records.
    /// </summary>
    public class TrashQuery : Query<TrashQuery, TrashField, TrashView, TrashOrderField>
    {
        /// <summary>
        /// Initialize a new trash query instance.
        /// </summary>
        public TrashQuery()
            : base("trash", typeof(Trash), true)
        {
        }

        /// <summary>
        /// Initialize a new trash query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the trash.</param>
        public TrashQuery(string id)
            : base("Trash", id, typeof(Trash), false)
        {
        }

        /// <summary>
        /// The account of the trashed record belongs to.
        /// </summary>
        public TrashQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// </summary>
        public TrashQuery SelectTrashed(HasLifeCycleStateQuery query)
        {
            query.FieldName = "trashed";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who trashed the record.
        /// </summary>
        public TrashQuery SelectTrashedBy(PersonQuery query)
        {
            query.FieldName = "trashedBy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
