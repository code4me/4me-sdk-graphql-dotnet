using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/contract/">Contract</see> object.
    /// </summary>
    public class Contract : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Used to select the appropriate category for the contract.
        /// </summary>
        [JsonProperty("category")]
        public ContractCategory? Category { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// All configuration items of the contract.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        [JsonProperty("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        [JsonProperty("customerAccount")]
        public Account? CustomerAccount { get; internal set; }

        /// <summary>
        /// The person who represents the customer organization for the contract.
        /// </summary>
        [JsonProperty("customerRepresentative")]
        public Person? CustomerRepresentative { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date through which the agreement will be active. The agreement expires at the end of this day if it is not renewed before then. When the agreement has expired, its status will automatically be set to <c>expired</c>.
        /// </summary>
        [JsonProperty("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate { get; internal set; }
#else
        public DateTime? ExpiryDate { get; internal set; }
#endif

        [JsonProperty("invoices")]
        internal NodeCollection<Invoice>? InvoicesCollection { get; set; }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public DataList<Invoice>? Invoices
        {
            get => InvoicesCollection?.Data;
        }

        /// <summary>
        /// <br>The name of the contract.</br>
        /// <br>If a unique ID is given to each contract, then this ID can be added at the start of the name.</br>
        /// <br></br>
        /// <br>Example:</br>
        /// <br>• 2EGXQ2W – Dell 3-Year ProSupport and Next Business Day Onsite Repair for CMP00035</br>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// The last day on which the service provider organization can still be contacted to terminate the agreement to ensure that it expires on the intended expiry date. The notice date field is left empty, and the expiry date field is filled out, when the agreement is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [JsonProperty("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate { get; internal set; }
#else
        public DateTime? NoticeDate { get; internal set; }
#endif

        /// <summary>
        /// Any additional information about the contract that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks { get; internal set; }

        [JsonProperty("remarksAttachments")]
        internal NodeCollection<Attachment>? RemarksAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public DataList<Attachment>? RemarksAttachments
        {
            get => RemarksAttachmentsCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The first day during which the agreement is active.
        /// </summary>
        [JsonProperty("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate { get; internal set; }
#else
        public DateTime? StartDate { get; internal set; }
#endif

        /// <summary>
        /// The current status of the agreement.
        /// </summary>
        [JsonProperty("status")]
        public AgreementStatus? Status { get; internal set; }

        /// <summary>
        /// The organization that has provided the contract to the customer.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The person who represents the supplier of the contract.
        /// </summary>
        [JsonProperty("supplierContact")]
        public Person? SupplierContact { get; internal set; }

        /// <summary>
        /// <br>The time zone that applies to the start date, notice date and expiry date of the contract.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ConfigurationItems?.AddRange((data as Contract)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as Contract)?.CustomFieldsAttachments);
            Invoices?.AddRange((data as Contract)?.Invoices);
            RemarksAttachments?.AddRange((data as Contract)?.RemarksAttachments);
        }
    }
}
