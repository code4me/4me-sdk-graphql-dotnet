namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new first line support agreement.
    /// </summary>
    internal class FirstLineSupportAgreementCreateMutation : Mutation<FirstLineSupportAgreementCreatePayload, FirstLineSupportAgreementCreateInput>
    {
        /// <summary>
        /// Initialize an new FirstLineSupportAgreementCreate mutation instance.
        /// </summary>
        internal FirstLineSupportAgreementCreateMutation(FirstLineSupportAgreementCreateInput data)
            : base("firstLineSupportAgreementCreate", "FirstLineSupportAgreementCreateInput!", data, new HashSet<IQuery>() { new FirstLineSupportAgreementQuery() { FieldName = "firstLineSupportAgreement", IsConnection = false }.Select("*") })
        {
        }
    }
}
