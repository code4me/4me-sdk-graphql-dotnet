﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SprintBacklogItem">SprintBacklogItem</see> query.
    /// </summary>
    public class SprintBacklogItemQuery : Query<SprintBacklogItemQuery, SprintBacklogItemField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sprint backlog item query instance.
        /// </summary>
        public SprintBacklogItemQuery()
            : base("", typeof(SprintBacklogItem), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public SprintBacklogItemQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(HasSprintBacklogItemsQuery query)
        {
            query.FieldName = "record";
            return Select(query);
        }

        /// <summary>
        /// Sprint this record is part of.
        /// </summary>
        public SprintBacklogItemQuery SelectSprint(SprintQuery query)
        {
            query.FieldName = "sprint";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
