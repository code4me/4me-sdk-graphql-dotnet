using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttemplate/">ProjectTemplate</see> object.
    /// </summary>
    public class ProjectTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the project template may not be used to help register new projects.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? Disabled { get; internal set; }

        [JsonProperty("phases")]
        internal NodeCollection<ProjectTemplatePhase>? PhasesCollection { get; set; }

        /// <summary>
        /// Phases of the project template.
        /// </summary>
        public DataList<ProjectTemplatePhase>? Phases
        {
            get => PhasesCollection?.Data;
        }

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
        /// A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [JsonProperty("taskTemplateRelations")]
        internal NodeCollection<ProjectTaskTemplateRelation>? TaskTemplateRelationsCollection { get; set; }

        /// <summary>
        /// Task template relations of the project template.
        /// </summary>
        public DataList<ProjectTaskTemplateRelation>? TaskTemplateRelations
        {
            get => TaskTemplateRelationsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(PhasesCollection?.GetQueryPageInfo("phases", depth + 1));
            retval.AddRange(TaskTemplateRelationsCollection?.GetQueryPageInfo("taskTemplateRelations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Phases?.AddRange((data as ProjectTemplate)?.Phases);
            TaskTemplateRelations?.AddRange((data as ProjectTemplate)?.TaskTemplateRelations);
        }
    }
}
