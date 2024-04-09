namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SlaCoverageGroup">SlaCoverageGroup</see> query.
    /// </summary>
    public class SlaCoverageGroupQuery : Query<SlaCoverageGroupQuery, SlaCoverageGroupField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sla coverage group query instance.
        /// </summary>
        public SlaCoverageGroupQuery()
            : base("", typeof(SlaCoverageGroup), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaCoverageGroupQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaCoverageGroupQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// People of the SLA coverage group.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaCoverageGroupQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements linked to the SLA coverage group.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaCoverageGroupQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "slas";
            return Select(query);
        }
    }
}
