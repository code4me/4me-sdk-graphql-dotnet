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
    }
}
