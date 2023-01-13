namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasSprintBacklogItems">HasSprintBacklogItems</see> query.
    /// </summary>
    public class HasSprintBacklogItemsQuery : Query<HasSprintBacklogItemsQuery, HasSprintBacklogItemsField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has sprint backlog items query instance.
        /// </summary>
        public HasSprintBacklogItemsQuery()
            : base("", typeof(HasSprintBacklogItems), false)
        {
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public HasSprintBacklogItemsQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }
    }
}
