namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimeAllocation records.
    /// </summary>
    public class TimeAllocationQuery : Query<TimeAllocationQuery, TimeAllocationField, TimeAllocationView, TimeAllocationOrderField>
    {
        /// <summary>
        /// Initialize a new time allocation query instance.
        /// </summary>
        public TimeAllocationQuery()
            : base("timeAllocations", typeof(TimeAllocation), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public TimeAllocationQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Customer organizations of the time allocation.
        /// </summary>
        public TimeAllocationQuery SelectCustomers(OrganizationQuery query)
        {
            query.FieldName = "customers";
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        public TimeAllocationQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Organizations of the time allocation.
        /// </summary>
        public TimeAllocationQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// Services of the time allocation.
        /// </summary>
        public TimeAllocationQuery SelectServices(ServiceQuery query)
        {
            query.FieldName = "services";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public TimeAllocationQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
