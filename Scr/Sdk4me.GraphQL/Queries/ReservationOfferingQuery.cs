namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ReservationOffering records.
    /// </summary>
    public class ReservationOfferingQuery : Query<ReservationOfferingQuery, ReservationOfferingField, ReservationOfferingView, ReservationOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new reservation offering query instance.
        /// </summary>
        public ReservationOfferingQuery()
            : base("reservationOfferings", typeof(ReservationOffering), true)
        {
        }

        /// <summary>
        /// Initialize a new reservation offering query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the reservation offering.</param>
        public ReservationOfferingQuery(string id)
            : base("ReservationOffering", id, typeof(ReservationOffering), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ReservationOfferingQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Calendar field is used to select the calendar that defines the hours during which the configuration items can be made available for temporary use.
        /// </summary>
        public ReservationOfferingQuery SelectCalendar(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Configuration items field is used to select the configuration items that people, who are covered by an active service level agreement for the related service instance, should be able to reserve for temporary use after the reservation offering is related to a request template of the category ‘Reservation’.
        /// </summary>
        public ReservationOfferingQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// The Request templates table field lists the request templates to which the reservation offering is linked.
        /// </summary>
        public ReservationOfferingQuery SelectRequestTemplates(RequestTemplateQuery query)
        {
            query.FieldName = "requestTemplates";
            return Select(query);
        }

        /// <summary>
        /// The Service instance field is used to select the service instance for which people need to be covered in order to be able to make use of the reservation offering.
        /// </summary>
        public ReservationOfferingQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
