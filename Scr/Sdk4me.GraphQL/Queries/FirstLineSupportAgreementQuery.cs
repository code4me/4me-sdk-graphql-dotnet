namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving FirstLineSupportAgreement records.
    /// </summary>
    public class FirstLineSupportAgreementQuery : Query<FirstLineSupportAgreementQuery, FirstLineSupportAgreementField, FirstLineSupportAgreementView, FirstLineSupportAgreementOrderField>
    {
        /// <summary>
        /// Initialize a new first line support agreement query instance.
        /// </summary>
        public FirstLineSupportAgreementQuery()
            : base("firstLineSupportAgreements", typeof(FirstLineSupportAgreement), true)
        {
        }

        /// <summary>
        /// Initialize a new first line support agreement query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the first line support agreement.</param>
        public FirstLineSupportAgreementQuery(string id)
            : base("FirstLineSupportAgreement", id, typeof(FirstLineSupportAgreement), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectChargesAttachments(AttachmentQuery query)
        {
            query.FieldName = "chargesAttachments";
            return Select(query);
        }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectCustomer(OrganizationQuery query)
        {
            query.FieldName = "customer";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectCustomerAccount(AccountQuery query)
        {
            query.FieldName = "customerAccount";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who represents the customer organization for the first line support agreement.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectCustomerRepresentative(PersonQuery query)
        {
            query.FieldName = "customerRepresentative";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoice query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Organization that provides the first line support agreement.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectProvider(OrganizationQuery query)
        {
            query.FieldName = "provider";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// The specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectServiceDeskTeam(TeamQuery query)
        {
            query.FieldName = "serviceDeskTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectSupportHours(CalendarQuery query)
        {
            query.FieldName = "supportHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Target details field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FirstLineSupportAgreementQuery SelectTargetDetailsAttachments(AttachmentQuery query)
        {
            query.FieldName = "targetDetailsAttachments";
            return Select(query);
        }
    }
}
