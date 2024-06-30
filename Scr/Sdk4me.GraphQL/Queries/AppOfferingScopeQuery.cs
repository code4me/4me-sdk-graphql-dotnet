namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingScope">AppOfferingScope</see> query.
    /// </summary>
    public class AppOfferingScopeQuery : Query<AppOfferingScopeQuery, AppOfferingScopeField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new app offering scope query instance.
        /// </summary>
        public AppOfferingScopeQuery()
            : base("", typeof(AppOfferingScope), false)
        {
        }
    }
}
