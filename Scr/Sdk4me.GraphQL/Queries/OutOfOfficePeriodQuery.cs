namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving OutOfOfficePeriod records.
    /// </summary>
    public class OutOfOfficePeriodQuery : Query<OutOfOfficePeriodQuery, OutOfOfficePeriodField, OutOfOfficePeriodView, OutOfOfficePeriodOrderField>
    {
        /// <summary>
        /// Initialize a new out of office period query instance.
        /// </summary>
        public OutOfOfficePeriodQuery()
            : base("outOfOfficePeriods", typeof(OutOfOfficePeriod), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public OutOfOfficePeriodQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is selected as the approval delegate for the out of office period.
        /// </summary>
        public OutOfOfficePeriodQuery SelectApprovalDelegate(PersonQuery query)
        {
            query.FieldName = "approvalDelegate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Effort class field is used to generate time entries for the out of office period. This field is applicable if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        public OutOfOfficePeriodQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is out of office.
        /// </summary>
        public OutOfOfficePeriodQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        public OutOfOfficePeriodQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
