namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/interface/haslifecyclestate/">HasLifeCycleState</see> interface.
    /// </summary>
    public interface IHasLifeCycleState
    {
        /// <summary>
        /// Current state of the record.
        /// </summary>
        public LifeCycleState? LifeCycleState { get; }
    }
}
