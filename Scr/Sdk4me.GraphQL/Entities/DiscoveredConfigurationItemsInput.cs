﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredconfigurationitemsinput/">DiscoveredConfigurationItemsInput</see> object.
    /// </summary>
    public class DiscoveredConfigurationItemsInput : PropertyChangeSet
    {
        private string? source;
        private List<string>? alternativeSources;
        private string? supportTeam;
        private List<DiscoveredProductCategoryInput>? physicalAssets;
        private DiscoveredReferenceStrategiesInput? referenceStrategies;
        private string? clientMutationId;

        /// <summary>
        /// Identifier for the client application submitting the upload.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// Alternative identifiers for the client application. When a configuration item or product with the given `sourceID` is found linked to one of these alternative sources it will be identified as the same. For configuration items the source field in 4me will be updated to the `source` value supplied.
        /// </summary>
        [JsonProperty("alternativeSources")]
        public List<string>? AlternativeSources
        {
            get => alternativeSources;
            set => alternativeSources = Set("alternativeSources", value);
        }

        /// <summary>
        /// Name of the support team to use as default for new products and configuration items uploaded.
        /// </summary>
        [JsonProperty("supportTeam")]
        public string? SupportTeam
        {
            get => supportTeam;
            set => supportTeam = Set("supportTeam", value);
        }

        /// <summary>
        /// Physical assets to be uploaded, grouped by product category and product.
        /// </summary>
        [JsonProperty("physicalAssets")]
        public List<DiscoveredProductCategoryInput>? PhysicalAssets
        {
            get => physicalAssets;
            set => physicalAssets = Set("physicalAssets", value);
        }

        /// <summary>
        /// How to handle references to records already present in 4me.
        /// </summary>
        [JsonProperty("referenceStrategies")]
        public DiscoveredReferenceStrategiesInput? ReferenceStrategies
        {
            get => referenceStrategies;
            set => referenceStrategies = Set("referenceStrategies", value);
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
