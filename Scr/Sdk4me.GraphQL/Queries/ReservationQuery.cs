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
        /// The account this record belongs to.
        /// </summary>
        public ReservationQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The asset that is being reserved.
        /// </summary>
        public ReservationQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who created this reservation.
        /// </summary>
        public ReservationQuery SelectCreatedBy(PersonQuery query)
        {
            query.FieldName = "createdBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ReservationQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The person for whom this reservation was created.
        /// </summary>
        public ReservationQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Recurrency for the reservation.
        /// </summary>
        public ReservationQuery SelectRecurrence(RecurrenceQuery query)
        {
            query.FieldName = "recurrence";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The link to the request for reservation.
        /// </summary>
        public ReservationQuery SelectRequest(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The link to the reservation offering that was related to the request template used to request the reservation.
        /// </summary>
        public ReservationQuery SelectReservationOffering(ReservationOfferingQuery query)
        {
            query.FieldName = "reservationOffering";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
