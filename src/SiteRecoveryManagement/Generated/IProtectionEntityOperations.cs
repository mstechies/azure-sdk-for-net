// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of protection entity operations for the Site Recovery
    /// extension.
    /// </summary>
    public partial interface IProtectionEntityOperations
    {
        /// <summary>
        /// Commit failover of a protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='parameters'>
        /// Commit failover request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> CommitFailoverAsync(string protectionContainerId, string protectionEntityId, CommitFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Disable Protection for the given protection enity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> DisableProtectionAsync(string protectionContainerId, string protectionEntityId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enable Protection for the given protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='input'>
        /// Protection entity ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> EnableProtectionAsync(string protectionContainerId, string protectionEntityId, EnableProtectionInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the protection entity object by Id.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Vm object.
        /// </returns>
        Task<ProtectionEntityResponse> GetAsync(string protectionContainerId, string protectionEntityId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all protection entities.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list Vm operation.
        /// </returns>
        Task<ProtectionEntityListResponse> ListAsync(string protectionContainerId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Planned failover of a protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='parameters'>
        /// Planned failover request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> PlannedFailoverAsync(string protectionContainerId, string protectionEntityId, PlannedFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Reprotect operation for the given protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='parameters'>
        /// Reprotect request after failover.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> ReprotectAsync(string protectionContainerId, string protectionEntityId, ReprotectRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Synchronise Owner Information for the given protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> SyncOwnerInformationAsync(string protectionContainerId, string protectionEntityId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Test failover of a protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='parameters'>
        /// Test failover request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> TestFailoverAsync(string protectionContainerId, string protectionEntityId, TestFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unplanned failover of a protection entity.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Parent Protection Container ID.
        /// </param>
        /// <param name='protectionEntityId'>
        /// Protection entity ID.
        /// </param>
        /// <param name='parameters'>
        /// Planned failover request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> UnplannedFailoverAsync(string protectionContainerId, string protectionEntityId, UnplannedFailoverRequest parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}