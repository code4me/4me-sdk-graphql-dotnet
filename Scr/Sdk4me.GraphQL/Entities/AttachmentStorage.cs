using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/attachmentstorage/">AttachmentStorage</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class AttachmentStorage : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => UploadUri ?? ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// The permitted file extensions for uploads.
        /// </summary>
        [JsonProperty("allowedExtensions"), Sdk4meField(true)]
        public List<string>? AllowedExtensions { get; internal set; }

        /// <summary>
        /// Type of storage facility in use.
        /// </summary>
        [JsonProperty("provider"), Sdk4meField(true)]
        public string? Provider { get; internal set; }

        /// <summary>
        /// The mandatory fields and their values that should be added to an upload POST to the `uploadUri`.
        /// </summary>
        [JsonProperty("providerParameters"), Sdk4meField(true)]
        public JToken? ProviderParameters { get; internal set; }

        /// <summary>
        /// The maximum size (in bytes) for uploads.
        /// </summary>
        [JsonProperty("sizeLimit"), Sdk4meField(true)]
        public long? SizeLimit { get; internal set; }

        /// <summary>
        /// The uniform resource identifier that attachments should be uploaded to.
        /// </summary>
        [JsonProperty("uploadUri"), Sdk4meField(true)]
        public string? UploadUri { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
