namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequest">StandardServiceRequest</see> query.
    /// </summary>
    public class StandardServiceRequestQuery : Query<StandardServiceRequestQuery, StandardServiceRequestField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new standard service request query instance.
        /// </summary>
        public StandardServiceRequestQuery()
            : base("", typeof(StandardServiceRequest), true)
        {
        }

        /// <summary>
        /// The request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        /// <param name="query">The request template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "requestTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestQuery SelectResolutionTargetNotificationScheme(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "resolutionTargetNotificationScheme";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The response target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestQuery SelectResponseTargetNotificationScheme(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "responseTargetNotificationScheme";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service offering the standard service request belongs to.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestQuery SelectSupportHours(CalendarQuery query)
        {
            query.FieldName = "supportHours";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
