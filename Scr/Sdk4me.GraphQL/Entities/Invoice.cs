using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/invoice/">Invoice</see> object.
    /// </summary>
    public class Invoice : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The end date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationEnd")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationEnd { get; internal set; }
#else
        public DateTime? AmortizationEnd { get; internal set; }
#endif

        /// <summary>
        /// The start date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationStart { get; internal set; }
#else
        public DateTime? AmortizationStart { get; internal set; }
#endif

        /// <summary>
        /// Whether the invoice amount is to be amortized over time.
        /// </summary>
        [JsonProperty("amortize")]
        public bool? Amortize { get; internal set; }

        /// <summary>
        /// The product of the <c>unitPrice</c> field value and the <c>quantity</c> field value.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        [JsonProperty("contract")]
        public Contract? Contract { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// <br>Currency of the <c>amount</c> value of the invoice.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; internal set; }

        /// <summary>
        /// <br>Whether or not the invoice should be depreciated and if so, which depreciation method is to be applied. When creating a new invoice and a value is not specified for this field, and the invoice is related to a configuration item, the value is set to the depreciation method of the product of the configuration item.</br>
        /// <br>Valid values are:</br>
        /// <br>• <c>not_depreciated</c>: Not Depreciated</br>
        /// <br>• <c>double_declining_balance</c>: Double Declining Balance</br>
        /// <br>• <c>reducing_balance</c>: Reducing Balance (or Diminishing Value)</br>
        /// <br>• <c>straight_line</c>: Straight Line (or Prime Cost)</br>
        /// <br>• <c>sum_of_the_years_digits</c>: Sum of the Year's Digits</br>
        /// </summary>
        [JsonProperty("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod { get; internal set; }

        /// <summary>
        /// The date on which to start depreciating the asset.
        /// </summary>
        [JsonProperty("depreciationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? DepreciationStart { get; internal set; }
#else
        public DateTime? DepreciationStart { get; internal set; }
#endif

        /// <summary>
        /// Short description of what was acquired.
        /// </summary>
        [JsonProperty("description"), Sdk4meField(true)]
        public string? Description { get; internal set; }

        /// <summary>
        /// The unique identifier by which the invoice is known in the financial system.
        /// </summary>
        [JsonProperty("financialID")]
        public string? FinancialID { get; internal set; }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        [JsonProperty("flsa")]
        public FirstLineSupportAgreement? Flsa { get; internal set; }

        /// <summary>
        /// The date on which the invoice was sent out by the supplier.
        /// </summary>
        [JsonProperty("invoiceDate"), Sdk4meField(true)]
#if NET6_0_OR_GREATER
        public DateOnly? InvoiceDate { get; internal set; }
#else
        public DateTime? InvoiceDate { get; internal set; }
#endif

        /// <summary>
        /// The invoice number that the supplier specified on the invoice.
        /// </summary>
        [JsonProperty("invoiceNr"), Sdk4meField(true)]
        public string? InvoiceNr { get; internal set; }

        /// <summary>
        /// The number of the purchase order that was sent to supplier.
        /// </summary>
        [JsonProperty("poNr"), Sdk4meField(true)]
        public string? PoNr { get; internal set; }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        [JsonProperty("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The number of units that were acquired.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal? Quantity { get; internal set; }

        /// <summary>
        /// Used to specify the yearly rate that should be applied to calculate the depreciation of the invoice using the reducing balance (or diminishing value) method. When creating a new invoice and a value is not specified for this field, and the invoice is related to a CI, the value is set to the rate of the CI's product.
        /// </summary>
        [JsonProperty("rate")]
        public long? Rate { get; internal set; }

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
        /// The value of this invoice at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [JsonProperty("salvageValue")]
        public decimal? SalvageValue { get; internal set; }

        /// <summary>
        /// <br>The currency of the salvage value of this invoice.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("salvageValueCurrency")]
        public string? SalvageValueCurrency { get; internal set; }

        /// <summary>
        /// The service that covers this invoice.
        /// </summary>
        [JsonProperty("service")]
        public Service? Service { get; internal set; }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        [JsonProperty("sla")]
        public ServiceLevelAgreement? Sla { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The organization from which the invoice was received.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The amount that the supplier has charged per unit that was acquired.
        /// </summary>
        [JsonProperty("unitPrice")]
        public decimal? UnitPrice { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The number of years within which the invoice is to be depreciated. When creating a new invoice and a value is not specified for this field, and the invoice is related to a CI, the value is set to the useful life of the CI's product.
        /// </summary>
        [JsonProperty("usefulLife")]
        public long? UsefulLife { get; internal set; }

        /// <summary>
        /// The workflow linked to this invoice.
        /// </summary>
        [JsonProperty("workflow")]
        public Workflow? Workflow { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ConfigurationItems?.AddRange((data as Invoice)?.ConfigurationItems);
            RemarksAttachments?.AddRange((data as Invoice)?.RemarksAttachments);
        }
    }
}
