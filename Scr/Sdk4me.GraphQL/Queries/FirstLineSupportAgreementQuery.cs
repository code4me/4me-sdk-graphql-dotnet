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
        /// Inline images linked to the Charges field.
        /// </summary>
        public FirstLineSupportAgreementQuery SelectChargesAttachments(AttachmentQuery query)
        {
            query.FieldName = "chargesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public FirstLineSupportAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public FirstLineSupportAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Target details field.
        /// </summary>
        public FirstLineSupportAgreementQuery SelectTargetDetailsAttachments(AttachmentQuery query)
        {
            query.FieldName = "targetDetailsAttachments";
            return Select(query);
        }
    }
}
