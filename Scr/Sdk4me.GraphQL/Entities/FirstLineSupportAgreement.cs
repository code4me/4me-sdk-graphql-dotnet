using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/firstlinesupportagreement/">FirstLineSupportAgreement</see> object.
    /// </summary>
    public class FirstLineSupportAgreement : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The amounts that the customer will be charged for the first line support agreement. These can be recurring as well as one-off charges.
        /// </summary>
        [JsonProperty("charges")]
        public string? Charges { get; internal set; }

        [JsonProperty("chargesAttachments")]
        internal NodeCollection<Attachment>? ChargesAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        public DataList<Attachment>? ChargesAttachments
        {
            get => ChargesAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// The person who represents the customer organization for the first line support agreement.
        /// </summary>
        [JsonProperty("customerRepresentative")]
        public Person? CustomerRepresentative { get; internal set; }

        /// <summary>
        /// The date through which the agreement will be active. The agreement expires at the end of this day if it is not renewed before then. When the agreement has expired, its status will automatically be set to <c>expired</c>.
        /// </summary>
        [JsonProperty("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate { get; internal set; }
#else
        public DateTime? ExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team during their registration.
        /// </summary>
        [JsonProperty("firstCallResolutions")]
        public long? FirstCallResolutions { get; internal set; }

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
        /// The name of the first line support agreement.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// The minimum percentage of requests that are to be picked up by the service desk team within the pickup target.
        /// </summary>
        [JsonProperty("pickupsWithinTarget")]
        public long? PickupsWithinTarget { get; internal set; }

        /// <summary>
        /// The number of minutes within which a new or existing request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [JsonProperty("pickupTarget")]
        public long? PickupTarget { get; internal set; }

        /// <summary>
        /// Organization that provides the first line support agreement.
        /// </summary>
        [JsonProperty("provider"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Organization? Provider { get; internal set; }

        /// <summary>
        /// The maximum percentage of requests that were reopened (i.e. which status in the account that is covered by the first line support agreement was updated from <c>completed</c> to another status).
        /// </summary>
        [JsonProperty("rejectedSolutions")]
        public long? RejectedSolutions { get; internal set; }

        /// <summary>
        /// Any additional information about the first line support agreement that might prove useful.
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
        /// The minimum percentage of requests that are to be completed by the service desk team without having been assigned to any other team within the account that is covered by the first line support agreement.
        /// </summary>
        [JsonProperty("serviceDeskOnlyResolutions")]
        public long? ServiceDeskOnlyResolutions { get; internal set; }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team.
        /// </summary>
        [JsonProperty("serviceDeskResolutions")]
        public long? ServiceDeskResolutions { get; internal set; }

        /// <summary>
        /// The specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        [JsonProperty("serviceDeskTeam")]
        public Team? ServiceDeskTeam { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        [JsonProperty("status"), Sdk4meField(IsDefaultQueryProperty = true)]
        public AgreementStatus? Status { get; internal set; }

        /// <summary>
        /// The number of minutes within which a new or existing chat request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [JsonProperty("supportChatPickupTarget")]
        public long? SupportChatPickupTarget { get; internal set; }

        /// <summary>
        /// Calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        [JsonProperty("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// A description of all the targets of the first line support agreement.
        /// </summary>
        [JsonProperty("targetDetails")]
        public string? TargetDetails { get; internal set; }

        [JsonProperty("targetDetailsAttachments")]
        internal NodeCollection<Attachment>? TargetDetailsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Target details field.
        /// </summary>
        public DataList<Attachment>? TargetDetailsAttachments
        {
            get => TargetDetailsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// <br>The time zone that applies to the start, notice and expiry dates, and to the support hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ChargesAttachmentsCollection?.GetQueryPageInfo("chargesAttachments", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            retval.AddRange(TargetDetailsAttachmentsCollection?.GetQueryPageInfo("targetDetailsAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ChargesAttachments?.AddRange((data as FirstLineSupportAgreement)?.ChargesAttachments);
            Invoices?.AddRange((data as FirstLineSupportAgreement)?.Invoices);
            RemarksAttachments?.AddRange((data as FirstLineSupportAgreement)?.RemarksAttachments);
            TargetDetailsAttachments?.AddRange((data as FirstLineSupportAgreement)?.TargetDetailsAttachments);
        }
    }
}
