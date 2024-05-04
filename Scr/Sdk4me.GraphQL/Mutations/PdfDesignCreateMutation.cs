using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The pdf design response query.</param>
        internal PdfDesignCreateMutation(PdfDesignCreateInput data, PdfDesignQuery query)
            : base("pdfDesignCreate", "PdfDesignCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The pdf design response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
