namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasLifeCycleState">HasLifeCycleState</see> query.
    /// </summary>
    public class HasLifeCycleStateQuery : Query<HasLifeCycleStateQuery, HasLifeCycleStateField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has life cycle state query instance.
        /// </summary>
        public HasLifeCycleStateQuery()
            : base("", typeof(HasLifeCycleState), false)
        {
        }
    }
}
