// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Read-write endpoint of the failover group instance.
    /// </summary>
    public partial class FailoverGroupReadWriteEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the FailoverGroupReadWriteEndpoint
        /// class.
        /// </summary>
        public FailoverGroupReadWriteEndpoint()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailoverGroupReadWriteEndpoint
        /// class.
        /// </summary>
        /// <param name="failoverPolicy">Failover policy of the read-write
        /// endpoint for the failover group. Possible values include: 'Manual',
        /// 'Automatic'</param>
        /// <param name="failoverWithDataLossGracePeriodMinutes">Grace period
        /// before failover with data loss is attempted for the read-write
        /// endpoint.</param>
        public FailoverGroupReadWriteEndpoint(string failoverPolicy = default(string), int? failoverWithDataLossGracePeriodMinutes = default(int?))
        {
            FailoverPolicy = failoverPolicy;
            FailoverWithDataLossGracePeriodMinutes = failoverWithDataLossGracePeriodMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets failover policy of the read-write endpoint for the
        /// failover group. Possible values include: 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "failoverPolicy")]
        public string FailoverPolicy { get; set; }

        /// <summary>
        /// Gets or sets grace period before failover with data loss is
        /// attempted for the read-write endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "failoverWithDataLossGracePeriodMinutes")]
        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }

    }
}
