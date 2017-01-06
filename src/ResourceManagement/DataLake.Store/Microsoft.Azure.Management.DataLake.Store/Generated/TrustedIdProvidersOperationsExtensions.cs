// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Models;
    using Rest;
    using Rest.Azure;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TrustedIdProvidersOperations.
    /// </summary>
    public static partial class TrustedIdProvidersOperationsExtensions
    {
            /// <summary>
            /// Creates or updates the specified trusted identity provider. During update,
            /// the trusted identity provider with the specified name will be replaced with
            /// this new provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to add the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the create the trusted identity provider.
            /// </param>
            public static TrustedIdProvider CreateOrUpdate(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, TrustedIdProvider parameters)
            {
                return Task.Factory.StartNew(s => ((ITrustedIdProvidersOperations)s).CreateOrUpdateAsync(resourceGroupName, accountName, trustedIdProviderName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified trusted identity provider. During update,
            /// the trusted identity provider with the specified name will be replaced with
            /// this new provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to add the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the create the trusted identity provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrustedIdProvider> CreateOrUpdateAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, TrustedIdProvider parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified trusted identity provider from the specified Data
            /// Lake Store account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to delete.
            /// </param>
            public static void Delete(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName)
            {
                Task.Factory.StartNew(s => ((ITrustedIdProvidersOperations)s).DeleteAsync(resourceGroupName, accountName, trustedIdProviderName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified trusted identity provider from the specified Data
            /// Lake Store account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the specified Data Lake Store trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to retrieve.
            /// </param>
            public static TrustedIdProvider Get(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName)
            {
                return Task.Factory.StartNew(s => ((ITrustedIdProvidersOperations)s).GetAsync(resourceGroupName, accountName, trustedIdProviderName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake Store trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrustedIdProvider> GetAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity providers.
            /// </param>
            public static IPage<TrustedIdProvider> ListByAccount(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((ITrustedIdProvidersOperations)s).ListByAccountAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity providers.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TrustedIdProvider>> ListByAccountAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TrustedIdProvider> ListByAccountNext(this ITrustedIdProvidersOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ITrustedIdProvidersOperations)s).ListByAccountNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
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
            public static async Task<IPage<TrustedIdProvider>> ListByAccountNextAsync(this ITrustedIdProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

