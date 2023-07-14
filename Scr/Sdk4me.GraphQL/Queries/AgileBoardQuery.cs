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
        /// Initialize a new agile board query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the agile board.</param>
        public AgileBoardQuery(string id)
            : base("AgileBoard", id, typeof(AgileBoard), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public AgileBoardQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// Scrum sprint the agile board is currently linked to.
        /// </summary>
        public AgileBoardQuery SelectCurrentSprint(SprintQuery query)
        {
            query.FieldName = "currentSprint";
            query.IsConnection = false;
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

        /// <summary>
        /// Manager of the agile board.
        /// </summary>
        public AgileBoardQuery SelectManager(PersonQuery query)
        {
            query.FieldName = "manager";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
