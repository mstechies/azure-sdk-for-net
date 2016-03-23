// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Capture Virtual Machine parameters.
    /// </summary>
    public partial class VirtualMachineCaptureParameters
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureParameters
        /// class.
        /// </summary>
        public VirtualMachineCaptureParameters() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureParameters
        /// class.
        /// </summary>
        public VirtualMachineCaptureParameters(string vhdPrefix, string destinationContainerName, bool overwriteVhds)
        {
            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
        }

        /// <summary>
        /// Gets or sets the captured VirtualHardDisk's name prefix.
        /// </summary>
        [JsonProperty(PropertyName = "vhdPrefix")]
        public string VhdPrefix { get; set; }

        /// <summary>
        /// Gets or sets the destination container name.
        /// </summary>
        [JsonProperty(PropertyName = "destinationContainerName")]
        public string DestinationContainerName { get; set; }

        /// <summary>
        /// Gets or sets whether it overwrites destination VirtualHardDisk if
        /// true, in case of conflict.
        /// </summary>
        [JsonProperty(PropertyName = "overwriteVhds")]
        public bool OverwriteVhds { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (VhdPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VhdPrefix");
            }
            if (DestinationContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationContainerName");
            }
        }
    }
}