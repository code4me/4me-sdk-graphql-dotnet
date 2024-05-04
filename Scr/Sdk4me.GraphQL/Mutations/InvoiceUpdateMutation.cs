using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing invoice.
    /// </summary>
    internal class InvoiceUpdateMutation : Mutation<InvoiceUpdatePayload, InvoiceUpdateInput>
    {
        /// <summary>
        /// Initialize an new InvoiceUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The invoice response query.</param>
        internal InvoiceUpdateMutation(InvoiceUpdateInput data, InvoiceQuery query)
            : base("invoiceUpdate", "InvoiceUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The invoice response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(InvoiceQuery query)
        {
            query.FieldName = "invoice";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
