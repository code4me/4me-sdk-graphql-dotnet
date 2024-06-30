namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceOffering records.
    /// </summary>
    public class ServiceOfferingQuery : Query<ServiceOfferingQuery, ServiceOfferingField, ServiceOfferingView, ServiceOfferingFilter, ServiceOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new service offering query instance.
        /// </summary>
        public ServiceOfferingQuery()
            : base("serviceOfferings", typeof(ServiceOffering), true)
        {
        }

        /// <summary>
        /// Initialize a new service offering query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the service offering.</param>
        public ServiceOfferingQuery(string id)
            : base("ServiceOffering", id, typeof(ServiceOffering), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectChargesAttachments(AttachmentQuery query)
        {
            query.FieldName = "chargesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Continuity field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectContinuityAttachments(AttachmentQuery query)
        {
            query.FieldName = "continuityAttachments";
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request with an active affected SLA based on the service offering.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectDefaultEffortClass(EffortClassQuery query)
        {
            query.FieldName = "defaultEffortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Effort classes of the service offering.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectEffortClasses(EffortClassQuery query)
        {
            query.FieldName = "effortClasses";
            return Select(query);
        }

        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        /// <param name="query">The effort class rate query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectEffortClassRates(EffortClassRateQuery query)
        {
            query.FieldName = "effortClassRates";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Limitations field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectLimitationsAttachments(AttachmentQuery query)
        {
            query.FieldName = "limitationsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Penalties field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectPenaltiesAttachments(AttachmentQuery query)
        {
            query.FieldName = "penaltiesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Performance field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectPerformanceAttachments(AttachmentQuery query)
        {
            query.FieldName = "performanceAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Prerequisites field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectPrerequisitesAttachments(AttachmentQuery query)
        {
            query.FieldName = "prerequisitesAttachments";
            return Select(query);
        }

        /// <summary>
        /// The service for which the service offering is being prepared.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectServiceHours(CalendarQuery query)
        {
            query.FieldName = "serviceHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of the service offering.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Shop articles related to the service offering.
        /// </summary>
        /// <param name="query">The shop article query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectShopArticles(ShopArticleQuery query)
        {
            query.FieldName = "shopArticles";
            return Select(query);
        }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSlaNotificationSchemeHigh(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationSchemeHigh";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSlaNotificationSchemeLow(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationSchemeLow";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSlaNotificationSchemeMedium(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationSchemeMedium";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The sla notification scheme query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSlaNotificationSchemeTop(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationSchemeTop";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        /// <param name="query">The standard service request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequests";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Summary field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSummaryAttachments(AttachmentQuery query)
        {
            query.FieldName = "summaryAttachments";
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursCase(CalendarQuery query)
        {
            query.FieldName = "supportHoursCase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursHigh(CalendarQuery query)
        {
            query.FieldName = "supportHoursHigh";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursLow(CalendarQuery query)
        {
            query.FieldName = "supportHoursLow";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursMedium(CalendarQuery query)
        {
            query.FieldName = "supportHoursMedium";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursRfc(CalendarQuery query)
        {
            query.FieldName = "supportHoursRfc";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursRfi(CalendarQuery query)
        {
            query.FieldName = "supportHoursRfi";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectSupportHoursTop(CalendarQuery query)
        {
            query.FieldName = "supportHoursTop";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Termination field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectTerminationAttachments(AttachmentQuery query)
        {
            query.FieldName = "terminationAttachments";
            return Select(query);
        }

        /// <summary>
        /// The waiting for customer follow-up for a request when it remains in status waiting for customer and has an active SLA that is based on this service offering. Only enabled waiting for customer follow-ups that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The waiting for customer follow up query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceOfferingQuery SelectWaitingForCustomerFollowUp(WaitingForCustomerFollowUpQuery query)
        {
            query.FieldName = "waitingForCustomerFollowUp";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
