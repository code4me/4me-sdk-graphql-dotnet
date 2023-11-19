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
        public SlaCoverageGroupQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        public SlaCoverageGroupQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// People of the SLA coverage group.
        /// </summary>
        public SlaCoverageGroupQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements linked to the SLA coverage group.
        /// </summary>
        public SlaCoverageGroupQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "slas";
            return Select(query);
        }
    }
}
