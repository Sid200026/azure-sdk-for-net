// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps
{
    internal class AzureDevOpsRepoOperationSource : IOperationSource<AzureDevOpsRepoResource>
    {
        private readonly ArmClient _client;

        internal AzureDevOpsRepoOperationSource(ArmClient client)
        {
            _client = client;
        }

        AzureDevOpsRepoResource IOperationSource<AzureDevOpsRepoResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureDevOpsRepoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSecurityDevOpsContext.Default);
            return new AzureDevOpsRepoResource(_client, data);
        }

        async ValueTask<AzureDevOpsRepoResource> IOperationSource<AzureDevOpsRepoResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureDevOpsRepoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSecurityDevOpsContext.Default);
            return await Task.FromResult(new AzureDevOpsRepoResource(_client, data)).ConfigureAwait(false);
        }
    }
}
