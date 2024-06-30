namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Snapshot">Snapshot</see> query.
    /// </summary>
    public class SnapshotQuery : Query<SnapshotQuery, SnapshotField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new snapshot query instance.
        /// </summary>
        public SnapshotQuery()
            : base("", typeof(Snapshot), false)
        {
        }
    }
}
