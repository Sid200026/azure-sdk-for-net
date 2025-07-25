// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a ScriptLog along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ScriptLogResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetScriptLogResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmDeploymentScriptResource"/> using the GetScriptLog method.
    /// </summary>
    public partial class ScriptLogResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScriptLogResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="scriptName"> The scriptName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string scriptName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}/logs/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scriptLogDeploymentScriptsClientDiagnostics;
        private readonly DeploymentScriptsRestOperations _scriptLogDeploymentScriptsRestClient;
        private readonly ScriptLogData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/deploymentScripts/logs";

        /// <summary> Initializes a new instance of the <see cref="ScriptLogResource"/> class for mocking. </summary>
        protected ScriptLogResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptLogResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScriptLogResource(ArmClient client, ScriptLogData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptLogResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScriptLogResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptLogDeploymentScriptsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scriptLogDeploymentScriptsApiVersion);
            _scriptLogDeploymentScriptsRestClient = new DeploymentScriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptLogDeploymentScriptsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScriptLogData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets deployment script logs for a given deployment script name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}/logs/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_GetLogsDefault</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptLogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If 'tail' is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptLogResource>> GetAsync(int? tail = null, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptLogDeploymentScriptsClientDiagnostics.CreateScope("ScriptLogResource.Get");
            scope.Start();
            try
            {
                var response = await _scriptLogDeploymentScriptsRestClient.GetLogsDefaultAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tail, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptLogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets deployment script logs for a given deployment script name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}/logs/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_GetLogsDefault</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptLogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If 'tail' is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptLogResource> Get(int? tail = null, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptLogDeploymentScriptsClientDiagnostics.CreateScope("ScriptLogResource.Get");
            scope.Start();
            try
            {
                var response = _scriptLogDeploymentScriptsRestClient.GetLogsDefault(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tail, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptLogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
