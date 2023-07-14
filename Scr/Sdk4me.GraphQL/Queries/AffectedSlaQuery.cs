namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AffectedSla records.
    /// </summary>
    public class AffectedSlaQuery : Query<AffectedSlaQuery, AffectedSlaField, AffectedSlaView, AffectedSlaOrderField>
    {
        /// <summary>
        /// Initialize a new affected sla query instance.
        /// </summary>
        public AffectedSlaQuery()
            : base("affectedSlas", typeof(AffectedSla), true)
        {
        }

        /// <summary>
        /// Initialize a new affected sla query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the affected sla.</param>
        public AffectedSlaQuery(string id)
            : base("AffectedSla", id, typeof(AffectedSla), false)
        {
        }

        /// <summary>
        /// The First line team field is automatically set to the team that, at the time the affected SLA was created, was selected in the First line team field of the related service instance.
        /// </summary>
        public AffectedSlaQuery SelectFirstLineTeam(TeamQuery query)
        {
            query.FieldName = "firstLineTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Request field is automatically set to the request for which the affected SLA was generated.
        /// </summary>
        public AffectedSlaQuery SelectRequest(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// If the impact of the affected SLA is "Top - Service Down for Several Users", the Service hours field is automatically set to the service hours calendar of the service offering of the related service level agreement.
        /// </summary>
        public AffectedSlaQuery SelectServiceHours(CalendarQuery query)
        {
            query.FieldName = "serviceHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Service instance field is automatically set to the Service Instance that, at the time the affected SLA was created, was selected in the Service instance field of the related service level agreement.
        /// </summary>
        public AffectedSlaQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Service level agreement field is automatically set to the service level agreement that is considered affected.
        /// </summary>
        public AffectedSlaQuery SelectServiceLevelAgreement(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreement";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Standard service request field is automatically set to the standard service request that is linked to the service offering of the service level agreement and which response and resolution targets were used to calculate the <c>responseTargetAt</c> and <c>resolutionTargetAt</c> for the affected SLA.
        /// </summary>
        public AffectedSlaQuery SelectStandardServiceRequest(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequest";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// A list of time periods between which the clock was stopped for this affected SLA.
        /// </summary>
        public AffectedSlaQuery SelectStoppedClockPeriods(PeriodQuery query)
        {
            query.FieldName = "stoppedClockPeriods";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Supplier field is automatically set to the Organization that, at the time the affected SLA was created, was selected in the Service provider field of the related service instance. This field is only filled out, however, if this service provider is an external organization.
        /// </summary>
        public AffectedSlaQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Support hours field is automatically set to the support hours Calendar that was selected for the impact level specified above in the service offering of the related service level agreement.
        /// </summary>
        public AffectedSlaQuery SelectSupportHours(CalendarQuery query)
        {
            query.FieldName = "supportHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Support team field is automatically set to the team that, at the time the affected SLA was created, was selected in the Support team field of the related service instance.
        /// </summary>
        public AffectedSlaQuery SelectSupportTeam(TeamQuery query)
        {
            query.FieldName = "supportTeam";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
