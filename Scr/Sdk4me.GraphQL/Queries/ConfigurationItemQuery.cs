namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ConfigurationItem records.
    /// </summary>
    public class ConfigurationItemQuery : Query<ConfigurationItemQuery, ConfigurationItemField, ConfigurationItemView, ConfigurationItemOrderField>
    {
        /// <summary>
        /// Initialize a new configuration item query instance.
        /// </summary>
        public ConfigurationItemQuery()
            : base("configurationItems", typeof(ConfigurationItem), true)
        {
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        public ConfigurationItemQuery SelectCiRelations(ConfigurationItemRelationQuery query)
        {
            query.FieldName = "ciRelations";
            return Select(query);
        }

        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectContracts(ContractQuery query)
        {
            query.FieldName = "contracts";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ConfigurationItemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ConfigurationItemQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        public ConfigurationItemQuery SelectLicensedSites(SiteQuery query)
        {
            query.FieldName = "licensedSites";
            return Select(query);
        }

        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ConfigurationItemQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectUsers(PersonQuery query)
        {
            query.FieldName = "users";
            return Select(query);
        }
    }
}
