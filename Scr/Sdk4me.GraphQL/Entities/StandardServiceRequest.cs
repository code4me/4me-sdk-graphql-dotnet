using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/standardservicerequest/">StandardServiceRequest</see> object.
    /// </summary>
    public class StandardServiceRequest : Node
    {
        /// <summary>
        /// Defines how the standard service request must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeType")]
        public ServiceOfferingChargeType? ChargeType { get; internal set; }

        /// <summary>
        /// The date and time at which the standard service request was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for the standard service request.
        /// </summary>
        [JsonProperty("rate")]
        public decimal? Rate { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of the standard service request.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateCurrency")]
        public string? RateCurrency { get; internal set; }

        /// <summary>
        /// The request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [JsonProperty("requestTemplate"), Sdk4meField(IsDefaultQueryProperty = true)]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTarget")]
        public long? ResolutionTarget { get; internal set; }

        /// <summary>
        /// Resolution target is Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetBestEffort")]
        public bool? ResolutionTargetBestEffort { get; internal set; }

        /// <summary>
        /// Number of business days within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetInDays")]
        public long? ResolutionTargetInDays { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [JsonProperty("resolutionTargetNotificationScheme")]
        public SlaNotificationScheme? ResolutionTargetNotificationScheme { get; internal set; }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTarget")]
        public long? ResponseTarget { get; internal set; }

        /// <summary>
        /// Response target is Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetBestEffort")]
        public bool? ResponseTargetBestEffort { get; internal set; }

        /// <summary>
        /// Number of business days within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetInDays")]
        public long? ResponseTargetInDays { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [JsonProperty("responseTargetNotificationScheme")]
        public SlaNotificationScheme? ResponseTargetNotificationScheme { get; internal set; }

        /// <summary>
        /// Service offering the standard service request belongs to.
        /// </summary>
        [JsonProperty("serviceOffering"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ServiceOffering? ServiceOffering { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [Obsolete("Use resolutionTargetNotificationScheme instead.")]
        [JsonProperty("slaNotificationScheme")]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the standard service request. If the standard service request has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
