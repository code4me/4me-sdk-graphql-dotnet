namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardItem">AgileBoardItem</see> query.
    /// </summary>
    public class AgileBoardItemQuery : Query<AgileBoardItemQuery, AgileBoardItemField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new agile board item query instance.
        /// </summary>
        public AgileBoardItemQuery()
            : base("", typeof(AgileBoardItem), true)
        {
        }
    }
}
