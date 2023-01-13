namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AffectedSla records.
    /// </summary>
    public class AffectedSlaQuery : Query<AffectedSlaQuery, AffectedSlaField, AffectedSlaView, AffectedSlaOrderField>
    {
        /// <summary>
        /// Initialize a new affected service level agreement query instance.
        /// </summary>
        public AffectedSlaQuery()
            : base("affectedSlas", typeof(AffectedSla), true)
        {
        }
    }
}
