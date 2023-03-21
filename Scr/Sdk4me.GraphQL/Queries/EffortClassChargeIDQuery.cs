namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassChargeID">EffortClassChargeID</see> query.
    /// </summary>
    public class EffortClassChargeIDQuery : Query<EffortClassChargeIDQuery, EffortClassChargeIDField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new effort class charge id query instance.
        /// </summary>
        public EffortClassChargeIDQuery()
            : base("", typeof(EffortClassChargeID), true)
        {
        }
    }
}
