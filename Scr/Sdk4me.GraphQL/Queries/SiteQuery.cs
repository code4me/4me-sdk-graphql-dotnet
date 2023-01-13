namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Site records.
    /// </summary>
    public class SiteQuery : Query<SiteQuery, SiteField, SiteView, SiteOrderField>
    {
        /// <summary>
        /// Initialize a new site query instance.
        /// </summary>
        public SiteQuery()
            : base("sites", typeof(Site), true)
        {
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public SiteQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public SiteQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// People of the site.
        /// </summary>
        public SiteQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public SiteQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
