namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving PdfDesign records.
    /// </summary>
    public class PdfDesignQuery : Query<PdfDesignQuery, PdfDesignField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new pdf design query instance.
        /// </summary>
        public PdfDesignQuery()
            : base("pdfDesigns", typeof(PdfDesign), true)
        {
        }

        /// <summary>
        /// Initialize a new pdf design query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the pdf design.</param>
        public PdfDesignQuery(string id)
            : base("PdfDesign", id, typeof(PdfDesign), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public PdfDesignQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public PdfDesignQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public PdfDesignQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
