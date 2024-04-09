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
        /// Initialize a new out of office period query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the out of office period.</param>
        public OutOfOfficePeriodQuery(string id)
            : base("OutOfOfficePeriod", id, typeof(OutOfOfficePeriod), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public OutOfOfficePeriodQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is selected as the approval delegate for the out of office period.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public OutOfOfficePeriodQuery SelectApprovalDelegate(PersonQuery query)
        {
            query.FieldName = "approvalDelegate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Effort class field is used to generate time entries for the out of office period. This field is applicable if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public OutOfOfficePeriodQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is out of office.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public OutOfOfficePeriodQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        /// <param name="query">The time allocation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public OutOfOfficePeriodQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
