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
        internal PersonCreateMutation(PersonCreateInput data)
            : base("personCreate", "PersonCreateInput!", data, new HashSet<IQuery>() { new PersonQuery() { FieldName = "person", IsConnection = false }.Select("*") })
        {
        }
    }
}
