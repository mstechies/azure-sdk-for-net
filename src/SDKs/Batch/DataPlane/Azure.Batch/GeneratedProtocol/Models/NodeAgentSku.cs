// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A node agent SKU supported by the Batch service.
    /// </summary>
    /// <remarks>
    /// The Batch node agent is a program that runs on each node in the pool,
    /// and provides the command-and-control interface between the node and the
    /// Batch service. There are different implementations of the node agent,
    /// known as SKUs, for different operating systems.
    /// </remarks>
    public partial class NodeAgentSku
    {
        /// <summary>
        /// Initializes a new instance of the NodeAgentSku class.
        /// </summary>
        public NodeAgentSku() { }

        /// <summary>
        /// Initializes a new instance of the NodeAgentSku class.
        /// </summary>
        /// <param name="id">The ID of the node agent SKU.</param>
        /// <param name="verifiedImageReferences">The list of images verified
        /// to be compatible with this node agent SKU.</param>
        /// <param name="osType">The type of operating system (e.g. Windows or
        /// Linux) compatible with the node agent SKU.</param>
        public NodeAgentSku(string id = default(string), System.Collections.Generic.IList<ImageReference> verifiedImageReferences = default(System.Collections.Generic.IList<ImageReference>), OSType? osType = default(OSType?))
        {
            Id = id;
            VerifiedImageReferences = verifiedImageReferences;
            OsType = osType;
        }

        /// <summary>
        /// Gets or sets the ID of the node agent SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of images verified to be compatible with this
        /// node agent SKU.
        /// </summary>
        /// <remarks>
        /// This collection is not exhaustive (the node agent may be compatible
        /// with other images).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "verifiedImageReferences")]
        public System.Collections.Generic.IList<ImageReference> VerifiedImageReferences { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system (e.g. Windows or Linux)
        /// compatible with the node agent SKU.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'linux', 'windows'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osType")]
        public OSType? OsType { get; set; }

    }
}
