using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new reservation.
    /// </summary>
    internal class ReservationCreateMutation : Mutation<ReservationCreatePayload, ReservationCreateInput>
    {
        /// <summary>
        /// Initialize an new ReservationCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The reservation response query.</param>
        internal ReservationCreateMutation(ReservationCreateInput data, ReservationQuery query)
            : base("reservationCreate", "ReservationCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The reservation response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReservationQuery query)
        {
            query.FieldName = "reservation";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
