// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for TenantEventsOperations.
    /// </summary>
    public static partial class TenantEventsOperationsExtensions
    {
            /// <summary>
            /// Provides the list of tenant events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// The list of property names to be returned. Possible values are:
            /// authorization, channels, claims, correlationId, description, eventDataId,
            /// eventName, eventTimestamp, httpRequest, level, operationId,
            /// operationName, properties, resourceGroupName, resourceProviderName,
            /// resourceId, status, submissionTimestamp, subStatus, subscriptionId
            /// </param>
            public static Microsoft.Rest.Azure.IPage<EventData> List(this ITenantEventsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<EventData> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<EventData>), string select = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITenantEventsOperations)s).ListAsync(odataQuery, select), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the list of tenant events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// The list of property names to be returned. Possible values are:
            /// authorization, channels, claims, correlationId, description, eventDataId,
            /// eventName, eventTimestamp, httpRequest, level, operationId,
            /// operationName, properties, resourceGroupName, resourceProviderName,
            /// resourceId, status, submissionTimestamp, subStatus, subscriptionId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<EventData>> ListAsync(this ITenantEventsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<EventData> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<EventData>), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provides the list of tenant events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<EventData> ListNext(this ITenantEventsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITenantEventsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the list of tenant events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<EventData>> ListNextAsync(this ITenantEventsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
