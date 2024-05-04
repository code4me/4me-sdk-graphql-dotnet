using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new invoice.
    /// </summary>
    internal class InvoiceCreateMutation : Mutation<InvoiceCreatePayload, InvoiceCreateInput>
    {
        /// <summary>
        /// Initialize an new InvoiceCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The invoice response query.</param>
        internal InvoiceCreateMutation(InvoiceCreateInput data, InvoiceQuery query)
            : base("invoiceCreate", "InvoiceCreateInput!", data, GetQuery(query))
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
