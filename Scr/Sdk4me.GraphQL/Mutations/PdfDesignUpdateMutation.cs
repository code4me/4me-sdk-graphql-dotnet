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
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal PdfDesignUpdateMutation(PdfDesignUpdateInput data, PdfDesignQuery query)
            : base("pdfDesignUpdate", "PdfDesignUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
