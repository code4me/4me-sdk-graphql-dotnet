namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AgileBoard records.
    /// </summary>
    public class AgileBoardQuery : Query<AgileBoardQuery, AgileBoardField, AgileBoardView, AgileBoardFilter, AgileBoardOrderField>
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
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectColumns(AgileBoardColumnQuery query)
        {
            query.FieldName = "columns";
            return Select(query);
        }

        /// <summary>
        /// Scrum sprint the agile board is currently linked to.
        /// </summary>
        /// <param name="query">The sprint query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectCurrentSprint(SprintQuery query)
        {
            query.FieldName = "currentSprint";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Customer representatives of these service level agreements can view this board in Self Service.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectCustomerRepresentativeSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "customerRepresentativeSlas";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Manager of the agile board.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardQuery SelectManager(PersonQuery query)
        {
            query.FieldName = "manager";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
