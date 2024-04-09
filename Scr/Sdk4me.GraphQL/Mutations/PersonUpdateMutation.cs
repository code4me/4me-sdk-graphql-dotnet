namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing person.
    /// </summary>
    internal class PersonUpdateMutation : Mutation<PersonUpdatePayload, PersonUpdateInput>
    {
        /// <summary>
        /// Initialize an new PersonUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The person response query.</param>
        internal PersonUpdateMutation(PersonUpdateInput data, PersonQuery query)
            : base("personUpdate", "PersonUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The person response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
