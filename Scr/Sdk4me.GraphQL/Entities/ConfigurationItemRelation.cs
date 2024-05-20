using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/configurationitemrelation/">ConfigurationItemRelation</see> object.
    /// </summary>
    public class ConfigurationItemRelation : Node
    {
        /// <summary>
        /// Related configuration item.
        /// </summary>
        [JsonProperty("configurationItem"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// <br>The type of the relation. Valid values are:</br>
        /// <br>• <c>parent</c>: Use this relation type to link a software CI to the software suite or software distribution package that it is a module or application of. Also use this relation type to link a virtual machine, software distribution package or software CI to the physical computers on which it has been installed. This relation type is also used to link a hardware CI to the hardware CI that it is a component of, installed in, or directly connected to (not using the network). In case of an address CI, this relation type is used to create a link with the CI to which the address has been assigned.</br>
        /// <br>• <c>child</c>: Use this relation type to link a software suite or software distribution package to the software modules or applications that it is made up of. Also use this relation type to link a physical computer to the virtual machines, software distribution packages or software CIs that have been installed on it. This relation type is also used to link a hardware CI to its hardware components, CIs that have been installed in it, and CIs that are directly connected to it (not using the network). It is also used to link the addresses that have been assigned to it.</br>
        /// <br>• <c>network_connection</c>: Use this relation type to link a hardware CI to all other hardware CIs that have a direct network connection with this CI (e.g. a router to a switch).</br>
        /// <br>• <c>redundancy</c>: Use this relation type to link a hardware CI to all other hardware CIs that provide it redundancy. For example, a server that forms a cluster with another server.</br>
        /// <br>• <c>continuity</c>: Use this relation type to link a hardware CI to another hardware CI that is located at another site and which is to be used as replacement in case the service instance that the first hardware CI supports needs to be recovered at its continuity site.</br>
        /// <br>• <c>software_dependency</c>: Use this relation type to link a software CI to all other software CIs, software/interface configurations and databases that depend on this software CI, or which the software CI depends on.</br>
        /// </summary>
        [JsonProperty("relationType"), Sdk4meField(IsDefaultQueryProperty = true)]
        public CiRelationRelationType? RelationType { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the relation or the name of an external system
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
