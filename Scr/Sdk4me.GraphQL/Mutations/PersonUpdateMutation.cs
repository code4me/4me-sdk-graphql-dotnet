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
        internal PersonUpdateMutation(PersonUpdateInput data)
            : base("personUpdate", "PersonUpdateInput!", data, new HashSet<IQuery>() { new PersonQuery() { FieldName = "person", IsConnection = false }.Select("*") })
        {
        }
    }
}
