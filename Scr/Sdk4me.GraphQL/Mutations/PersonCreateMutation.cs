namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new person.
    /// </summary>
    internal class PersonCreateMutation : Mutation<PersonCreatePayload, PersonCreateInput>
    {
        /// <summary>
        /// Initialize an new PersonCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal PersonCreateMutation(PersonCreateInput data, PersonQuery query)
            : base("personCreate", "PersonCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
