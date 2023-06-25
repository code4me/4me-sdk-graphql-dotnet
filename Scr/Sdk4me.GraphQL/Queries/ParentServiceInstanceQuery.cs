namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ParentServiceInstance">ParentServiceInstance</see> query.
    /// </summary>
    public class ParentServiceInstanceQuery : Query<ParentServiceInstanceQuery, ParentServiceInstanceField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new parent service instance query instance.
        /// </summary>
        public ParentServiceInstanceQuery()
            : base("", typeof(ParentServiceInstance), true)
        {
        }

        /// <summary>
        /// Service instance consuming the service instance of the service level agreement.
        /// </summary>
        public ParentServiceInstanceQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
