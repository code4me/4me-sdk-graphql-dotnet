using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/invoiceupdateinput/">InvoiceUpdateInput</see> object.
    /// </summary>
    public class InvoiceUpdateInput : PropertyChangeSet
    {
#if NET6_0_OR_GREATER
        private DateOnly? amortizationEnd;
#else
        private DateTime? amortizationEnd;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? amortizationStart;
#else
        private DateTime? amortizationStart;
#endif
        private bool? amortize;
        private List<string>? ciIds;
        private string? clientMutationId;
        private string? contractId;
        private string? currency;
        private ProductDepreciationMethod? depreciationMethod;
#if NET6_0_OR_GREATER
        private DateOnly? depreciationStart;
#else
        private DateTime? depreciationStart;
#endif
        private string? description;
        private string? financialID;
        private string? flsaId;
        private string id;
#if NET6_0_OR_GREATER
        private DateOnly? invoiceDate;
#else
        private DateTime? invoiceDate;
#endif
        private string? invoiceNr;
        private string? poNr;
        private string? projectId;
        private decimal? quantity;
        private long? rate;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private decimal? salvageValue;
        private string? salvageValueCurrency;
        private string? serviceId;
        private string? slaId;
        private string? source;
        private string? sourceID;
        private string? supplierId;
        private decimal? unitPrice;
        private long? usefulLife;
        private string? workflowId;

        /// <summary>
        /// The end date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationEnd")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationEnd
#else
        public DateTime? AmortizationEnd
#endif
        {
            get => amortizationEnd;
            set => amortizationEnd = Set("amortizationEnd", value);
        }

        /// <summary>
        /// The start date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationStart
#else
        public DateTime? AmortizationStart
#endif
        {
            get => amortizationStart;
            set => amortizationStart = Set("amortizationStart", value);
        }

        /// <summary>
        /// Whether the invoice amount is to be amortized over time.
        /// </summary>
        [JsonProperty("amortize")]
        public bool? Amortize
        {
            get => amortize;
            set => amortize = Set("amortize", value);
        }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        [JsonProperty("ciIds")]
        public List<string>? CiIds
        {
            get => ciIds;
            set => ciIds = Set("ciIds", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        [JsonProperty("contractId")]
        public string? ContractId
        {
            get => contractId;
            set => contractId = Set("contractId", value);
        }

        /// <summary>
        /// <br>Currency of the <c>amount</c> value of the invoice.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency
        {
            get => currency;
            set => currency = Set("currency", value);
        }

        /// <summary>
        /// <br>Used to specify whether or not configuration items that are linked to this invoice are depreciated</br>
        /// <br>and if so, which depreciation method is to be applied. Valid values are:</br>
        /// <br>• <c>not_depreciated</c>: Not Depreciated</br>
        /// <br>• <c>double_declining_balance</c>: Double Declining Balance</br>
        /// <br>• <c>reducing_balance</c>: Reducing Balance (or Diminishing Value)</br>
        /// <br>• <c>straight_line</c>: Straight Line (or Prime Cost)</br>
        /// <br>• <c>sum_of_the_years_digits</c>: Sum of the Year's Digits</br>
        /// </summary>
        [JsonProperty("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod
        {
            get => depreciationMethod;
            set => depreciationMethod = Set("depreciationMethod", value);
        }

        /// <summary>
        /// The date on which to start depreciating the asset.
        /// </summary>
        [JsonProperty("depreciationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? DepreciationStart
#else
        public DateTime? DepreciationStart
#endif
        {
            get => depreciationStart;
            set => depreciationStart = Set("depreciationStart", value);
        }

        /// <summary>
        /// Short description of what was acquired.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The unique identifier by which the invoice is known in the financial system.
        /// </summary>
        [JsonProperty("financialID")]
        public string? FinancialID
        {
            get => financialID;
            set => financialID = Set("financialID", value);
        }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        [JsonProperty("flsaId")]
        public string? FlsaId
        {
            get => flsaId;
            set => flsaId = Set("flsaId", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The date on which the invoice was sent out by the supplier.
        /// </summary>
        [JsonProperty("invoiceDate")]
#if NET6_0_OR_GREATER
        public DateOnly? InvoiceDate
#else
        public DateTime? InvoiceDate
#endif
        {
            get => invoiceDate;
            set => invoiceDate = Set("invoiceDate", value);
        }

        /// <summary>
        /// The invoice number that the supplier specified on the invoice.
        /// </summary>
        [JsonProperty("invoiceNr")]
        public string? InvoiceNr
        {
            get => invoiceNr;
            set => invoiceNr = Set("invoiceNr", value);
        }

        /// <summary>
        /// Number of the purchase order that was used to order the (lease of the) configuration item from the supplier.
        /// </summary>
        [JsonProperty("poNr")]
        public string? PoNr
        {
            get => poNr;
            set => poNr = Set("poNr", value);
        }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        [JsonProperty("projectId")]
        public string? ProjectId
        {
            get => projectId;
            set => projectId = Set("projectId", value);
        }

        /// <summary>
        /// The number of units that were acquired.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal? Quantity
        {
            get => quantity;
            set => quantity = Set("quantity", value);
        }

        /// <summary>
        /// Used to specify the yearly rate that should be applied to calculate the depreciation of the configuration item (CI) using the reducing balance (or diminishing value) method. When creating a new CI and a value is not specified for this field, it is set to the rate of the CI's product.
        /// </summary>
        [JsonProperty("rate")]
        public long? Rate
        {
            get => rate;
            set => rate = Set("rate", value);
        }

        /// <summary>
        /// Any additional information about the invoice that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [JsonProperty("remarksAttachments")]
        public List<AttachmentInput>? RemarksAttachments
        {
            get => remarksAttachments;
            set => remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The value of this configuration item at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [JsonProperty("salvageValue")]
        public decimal? SalvageValue
        {
            get => salvageValue;
            set => salvageValue = Set("salvageValue", value);
        }

        /// <summary>
        /// <br>The currency of the salvage value attributed to this configuration item.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("salvageValueCurrency")]
        public string? SalvageValueCurrency
        {
            get => salvageValueCurrency;
            set => salvageValueCurrency = Set("salvageValueCurrency", value);
        }

        /// <summary>
        /// The service that covers this invoice. Can only be set when the invoice is linked to a contract or configuration items.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        [JsonProperty("slaId")]
        public string? SlaId
        {
            get => slaId;
            set => slaId = Set("slaId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Identifier of the organization from which the invoice was received.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The amount that the supplier has charged per unit that was acquired.
        /// </summary>
        [JsonProperty("unitPrice")]
        public decimal? UnitPrice
        {
            get => unitPrice;
            set => unitPrice = Set("unitPrice", value);
        }

        /// <summary>
        /// The number of years within which the configuration item is to be depreciated. When creating a new CI and a value is not specified for this field, it is set to the useful life of the CI's product.
        /// </summary>
        [JsonProperty("usefulLife")]
        public long? UsefulLife
        {
            get => usefulLife;
            set => usefulLife = Set("usefulLife", value);
        }

        /// <summary>
        /// The workflow linked to this invoice.
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId
        {
            get => workflowId;
            set => workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public InvoiceUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
