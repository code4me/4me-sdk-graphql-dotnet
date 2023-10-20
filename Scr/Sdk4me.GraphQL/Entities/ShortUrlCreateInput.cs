namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlcreateinput/">ShortUrlCreateInput</see> object.
    /// </summary>
    public class ShortUrlCreateInput : PropertyChangeSet
    {
        private string? ciId;
        private string? clientMutationId;
        private string? dashboardId;
        private ShortUrlEmailInput? email;
        private ShortUrlGeoInput? geo;
        private string? knowledgeArticleId;
        private string? mapAddress;
        private string? plainText;
        private string? requestTemplateId;
        private string? skypeName;
        private ShortUrlSmsInput? sms;
        private string? tel;
        private string? tweet;
        private string? twitterName;
        private string? uri;
        private string? websiteUrl;

        /// <summary>
        /// Identifier of the CI for which a request is to be registered in 4me Self Service when the short URL is used.
        /// </summary>
        [JsonProperty("ciId")]
        public string? CiId
        {
            get => ciId;
            set => ciId = Set("ciId", value);
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
        /// Identifier of the dashboard which is to be opened when the short URL is used.
        /// </summary>
        [JsonProperty("dashboardId")]
        public string? DashboardId
        {
            get => dashboardId;
            set => dashboardId = Set("dashboardId", value);
        }

        /// <summary>
        /// Values for email that is to be generated when the short URL is used.
        /// </summary>
        [JsonProperty("email")]
        public ShortUrlEmailInput? Email
        {
            get => email;
            set => email = Set("email", value);
        }

        /// <summary>
        /// Coordinates of the location for which a map should be opened when the short URL is used.
        /// </summary>
        [JsonProperty("geo")]
        public ShortUrlGeoInput? Geo
        {
            get => geo;
            set => geo = Set("geo", value);
        }

        /// <summary>
        /// Identifier of the knowledge article which instructions need to be displayed when the short URL is used in 4me Self Service.
        /// </summary>
        [JsonProperty("knowledgeArticleId")]
        public string? KnowledgeArticleId
        {
            get => knowledgeArticleId;
            set => knowledgeArticleId = Set("knowledgeArticleId", value);
        }

        /// <summary>
        /// The address (or only the city or country) for which a map should be opened when the short URL is used.
        /// </summary>
        [JsonProperty("mapAddress")]
        public string? MapAddress
        {
            get => mapAddress;
            set => mapAddress = Set("mapAddress", value);
        }

        /// <summary>
        /// The Plain text field is used to enter the text that should be displayed when the short URL is used.
        /// </summary>
        [JsonProperty("plainText")]
        public string? PlainText
        {
            get => plainText;
            set => plainText = Set("plainText", value);
        }

        /// <summary>
        /// The identifier of the request template that is to be applied to each new request that is opened when in 4me Self Service when the short URL is used.
        /// </summary>
        [JsonProperty("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => requestTemplateId;
            set => requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// The Skype name that is to be called when the short URL is used.
        /// </summary>
        [JsonProperty("skypeName")]
        public string? SkypeName
        {
            get => skypeName;
            set => skypeName = Set("skypeName", value);
        }

        /// <summary>
        /// Values for the SMS message that is to be generated when the short URL is used.
        /// </summary>
        [JsonProperty("sms")]
        public ShortUrlSmsInput? Sms
        {
            get => sms;
            set => sms = Set("sms", value);
        }

        /// <summary>
        /// The telephone number that is to be called when the short URL is used.
        /// </summary>
        [JsonProperty("tel")]
        public string? Tel
        {
            get => tel;
            set => tel = Set("tel", value);
        }

        /// <summary>
        /// The Twitter tweet that is to be generated when the short URL is used.
        /// </summary>
        [JsonProperty("tweet")]
        public string? Tweet
        {
            get => tweet;
            set => tweet = Set("tweet", value);
        }

        /// <summary>
        /// The name of the Twitter user whose Twitter feed is to be opened when the short URL is used.
        /// </summary>
        [JsonProperty("twitterName")]
        public string? TwitterName
        {
            get => twitterName;
            set => twitterName = Set("twitterName", value);
        }

        /// <summary>
        /// The uniform resource identifier (URI) to which the short URL is forwarded.
        /// </summary>
        [JsonProperty("uri")]
        public string? Uri
        {
            get => uri;
            set => uri = Set("uri", value);
        }

        /// <summary>
        /// The uniform resource locator of a website to which the short URL is to forward when it is used.
        /// </summary>
        [JsonProperty("websiteUrl")]
        public string? WebsiteUrl
        {
            get => websiteUrl;
            set => websiteUrl = Set("websiteUrl", value);
        }
    }
}
