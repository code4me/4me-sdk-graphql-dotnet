namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing PDF design.
    /// </summary>
    internal class PdfDesignUpdateMutation : Mutation<PdfDesignUpdatePayload, PdfDesignUpdateInput>
    {
        /// <summary>
        /// Initialize an new PdfDesignUpdate mutation instance.
        /// </summary>
        internal PdfDesignUpdateMutation(PdfDesignUpdateInput data)
            : base("pdfDesignUpdate", "PdfDesignUpdateInput!", data, new HashSet<IQuery>() { new PdfDesignQuery() { FieldName = "pdfDesign", IsConnection = false }.Select("*") })
        {
        }
    }
}
