namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AgileBoard records.
    /// </summary>
    public class AgileBoardQuery : Query<AgileBoardQuery, AgileBoardField, AgileBoardView, AgileBoardOrderField>
    {
        /// <summary>
        /// Initialize a new agile board query instance.
        /// </summary>
        public AgileBoardQuery()
            : base("agileBoards", typeof(AgileBoard), true)
        {
        }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        public AgileBoardQuery SelectColumns(AgileBoardColumnQuery query)
        {
            query.FieldName = "columns";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public AgileBoardQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }
    }
}
