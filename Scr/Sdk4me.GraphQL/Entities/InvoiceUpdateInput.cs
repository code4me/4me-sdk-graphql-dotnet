namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/invoiceupdateinput/">InvoiceUpdateInput</see> object.
    /// </summary>
    public class InvoiceUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? workflowId;
        private string? projectId;
        private string? slaId;
        private string? flsaId;
        private string? contractId;
        private List<string>? ciIds;
        private bool? amortize;
        private DateOnly? amortizationStart;
        private DateOnly? amortizationEnd;
        private string? currency;
        private ProductDepreciationMethod? depreciationMethod;
        private DateOnly? depreciationStart;
        private string? description;
        private DateOnly? invoiceDate;
        private string? invoiceNr;
        private string? poNr;
        private decimal? quantity;
        private string? remarks;
        private string? serviceId;
        private string? supplierId;
        private long? rate;
        private decimal? salvageValue;
        private string? salvageValueCurrency;
        private decimal? unitPrice;
        private long? usefulLife;
        private string? id;
        private string? clientMutationId;

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
        /// The workflow linked to this invoice.
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId
        {
            get => workflowId;
            set => workflowId = Set("workflowId", value);
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
        /// The service level agreement linked to this invoice.
        /// </summary>
        [JsonProperty("slaId")]
        public string? SlaId
        {
            get => slaId;
            set => slaId = Set("slaId", value);
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
        /// The contract linked to this invoice.
        /// </summary>
        [JsonProperty("contractId")]
        public string? ContractId
        {
            get => contractId;
            set => contractId = Set("contractId", value);
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
        /// Whether the invoice amount is to be amortized over time.
        /// </summary>
        [JsonProperty("amortize")]
        public bool? Amortize
        {
            get => amortize;
            set => amortize = Set("amortize", value);
        }

        /// <summary>
        /// The start date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationStart")]
        public DateOnly? AmortizationStart
        {
            get => amortizationStart;
            set => amortizationStart = Set("amortizationStart", value);
        }

        /// <summary>
        /// The end date of the period over which the invoice is to be amortized.
        /// </summary>
        [JsonProperty("amortizationEnd")]
        public DateOnly? AmortizationEnd
        {
            get => amortizationEnd;
            set => amortizationEnd = Set("amortizationEnd", value);
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
        public DateOnly? DepreciationStart
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
        /// The date on which the invoice was sent out by the supplier.
        /// </summary>
        [JsonProperty("invoiceDate")]
        public DateOnly? InvoiceDate
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
        /// The number of units that were acquired.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal? Quantity
        {
            get => quantity;
            set => quantity = Set("quantity", value);
        }

        /// <summary>
        /// Any additional information about the contract that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
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
        /// Identifier of the organization from which the invoice was received.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
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
    }
}
