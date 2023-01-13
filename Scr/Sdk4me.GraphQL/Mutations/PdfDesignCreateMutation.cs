namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new PDF design.
    /// </summary>
    internal class PdfDesignCreateMutation : Mutation<PdfDesignCreatePayload, PdfDesignCreateInput>
    {
        /// <summary>
        /// Initialize an new PdfDesignCreate mutation instance.
        /// </summary>
        internal PdfDesignCreateMutation(PdfDesignCreateInput data)
            : base("pdfDesignCreate", "PdfDesignCreateInput!", data, new HashSet<IQuery>() { new PdfDesignQuery() { FieldName = "pdfDesign", IsConnection = false }.Select("*") })
        {
        }
    }
}
