namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing first line support agreement.
    /// </summary>
    internal class FirstLineSupportAgreementUpdateMutation : Mutation<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdateInput>
    {
        /// <summary>
        /// Initialize an new FirstLineSupportAgreementUpdate mutation instance.
        /// </summary>
        internal FirstLineSupportAgreementUpdateMutation(FirstLineSupportAgreementUpdateInput data)
            : base("firstLineSupportAgreementUpdate", "FirstLineSupportAgreementUpdateInput!", data, new HashSet<IQuery>() { new FirstLineSupportAgreementQuery() { FieldName = "firstLineSupportAgreement", IsConnection = false }.Select("*") })
        {
        }
    }
}
