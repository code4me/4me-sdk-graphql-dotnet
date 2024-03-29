﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Record">Record</see> query.
    /// </summary>
    public class RecordQuery : Query<RecordQuery, RecordField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new record query instance.
        /// </summary>
        public RecordQuery()
            : base("", typeof(Record), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public RecordQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
