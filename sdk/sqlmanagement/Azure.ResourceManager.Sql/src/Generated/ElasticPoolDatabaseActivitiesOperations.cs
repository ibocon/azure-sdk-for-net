// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ElasticPoolDatabaseActivities service client. </summary>
    public partial class ElasticPoolDatabaseActivitiesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ElasticPoolDatabaseActivitiesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivitiesOperations for mocking. </summary>
        protected ElasticPoolDatabaseActivitiesOperations()
        {
        }

        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivitiesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ElasticPoolDatabaseActivitiesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ElasticPoolDatabaseActivitiesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns activity on databases inside of an elastic pool. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="elasticPoolName"/> is null. </exception>
        public virtual AsyncPageable<ElasticPoolDatabaseActivity> ListByElasticPoolAsync(string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            async Task<Page<ElasticPoolDatabaseActivity>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolDatabaseActivitiesOperations.ListByElasticPool");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByElasticPoolAsync(resourceGroupName, serverName, elasticPoolName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Returns activity on databases inside of an elastic pool. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Pageable<ElasticPoolDatabaseActivity> ListByElasticPool(string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            Page<ElasticPoolDatabaseActivity> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolDatabaseActivitiesOperations.ListByElasticPool");
                scope.Start();
                try
                {
                    var response = RestClient.ListByElasticPool(resourceGroupName, serverName, elasticPoolName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
