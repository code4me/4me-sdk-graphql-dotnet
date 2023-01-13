namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Reservation records.
    /// </summary>
    public class ReservationQuery : Query<ReservationQuery, ReservationField, ReservationView, ReservationOrderField>
    {
        /// <summary>
        /// Initialize a new reservation query instance.
        /// </summary>
        public ReservationQuery()
            : base("reservations", typeof(Reservation), true)
        {
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ReservationQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }
    }
}
