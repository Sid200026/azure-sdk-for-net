// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterPatchParameters represents the body of the request to patch the cluster properties. </summary>
    public partial class NetworkCloudClusterPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterPatch"/>. </summary>
        public NetworkCloudClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ComputeRackDefinitions = new ChangeTrackingList<NetworkCloudRackDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterPatch"/>. </summary>
        /// <param name="identity"> The identity for the resource. </param>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="aggregatorOrSingleRackDefinition"> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </param>
        /// <param name="analyticsOutputSettings"> The settings for the log analytics workspace used for output of logs from this cluster. </param>
        /// <param name="clusterLocation"> The customer-provided location information to identify where the cluster resides. </param>
        /// <param name="clusterServicePrincipal"> The service principal to be used by the cluster during Arc Appliance installation. </param>
        /// <param name="commandOutputSettings"> The settings for commands run in this cluster, such as bare metal machine run read only commands and data extracts. </param>
        /// <param name="computeDeploymentThreshold"> The validation threshold indicating the allowable failures of compute machines during environment validation and deployment. </param>
        /// <param name="computeRackDefinitions">
        /// The list of rack definitions for the compute racks in a multi-rack
        /// cluster, or an empty list in a single-rack cluster.
        /// </param>
        /// <param name="runtimeProtectionConfiguration"> The settings for cluster runtime protection. </param>
        /// <param name="secretArchive"> The configuration for use of a key vault to store secrets for later retrieval by the operator. </param>
        /// <param name="secretArchiveSettings"> The settings for the secret archive used to hold credentials for the cluster. </param>
        /// <param name="updateStrategy"> The strategy for updating the cluster. </param>
        /// <param name="vulnerabilityScanningSettings"> The settings for how security vulnerability scanning is applied to the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudClusterPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, NetworkCloudRackDefinition aggregatorOrSingleRackDefinition, AnalyticsOutputSettings analyticsOutputSettings, string clusterLocation, ServicePrincipalInformation clusterServicePrincipal, CommandOutputSettings commandOutputSettings, ValidationThreshold computeDeploymentThreshold, IList<NetworkCloudRackDefinition> computeRackDefinitions, RuntimeProtectionConfiguration runtimeProtectionConfiguration, ClusterSecretArchive secretArchive, SecretArchiveSettings secretArchiveSettings, ClusterUpdateStrategy updateStrategy, VulnerabilityScanningSettingsPatch vulnerabilityScanningSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Tags = tags;
            AggregatorOrSingleRackDefinition = aggregatorOrSingleRackDefinition;
            AnalyticsOutputSettings = analyticsOutputSettings;
            ClusterLocation = clusterLocation;
            ClusterServicePrincipal = clusterServicePrincipal;
            CommandOutputSettings = commandOutputSettings;
            ComputeDeploymentThreshold = computeDeploymentThreshold;
            ComputeRackDefinitions = computeRackDefinitions;
            RuntimeProtectionConfiguration = runtimeProtectionConfiguration;
            SecretArchive = secretArchive;
            SecretArchiveSettings = secretArchiveSettings;
            UpdateStrategy = updateStrategy;
            VulnerabilityScanningSettings = vulnerabilityScanningSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </summary>
        public NetworkCloudRackDefinition AggregatorOrSingleRackDefinition { get; set; }
        /// <summary> The settings for the log analytics workspace used for output of logs from this cluster. </summary>
        public AnalyticsOutputSettings AnalyticsOutputSettings { get; set; }
        /// <summary> The customer-provided location information to identify where the cluster resides. </summary>
        public string ClusterLocation { get; set; }
        /// <summary> The service principal to be used by the cluster during Arc Appliance installation. </summary>
        public ServicePrincipalInformation ClusterServicePrincipal { get; set; }
        /// <summary> The settings for commands run in this cluster, such as bare metal machine run read only commands and data extracts. </summary>
        public CommandOutputSettings CommandOutputSettings { get; set; }
        /// <summary> The validation threshold indicating the allowable failures of compute machines during environment validation and deployment. </summary>
        public ValidationThreshold ComputeDeploymentThreshold { get; set; }
        /// <summary>
        /// The list of rack definitions for the compute racks in a multi-rack
        /// cluster, or an empty list in a single-rack cluster.
        /// </summary>
        public IList<NetworkCloudRackDefinition> ComputeRackDefinitions { get; }
        /// <summary> The settings for cluster runtime protection. </summary>
        internal RuntimeProtectionConfiguration RuntimeProtectionConfiguration { get; set; }
        /// <summary> The mode of operation for runtime protection. </summary>
        public RuntimeProtectionEnforcementLevel? RuntimeProtectionEnforcementLevel
        {
            get => RuntimeProtectionConfiguration is null ? default : RuntimeProtectionConfiguration.EnforcementLevel;
            set
            {
                if (RuntimeProtectionConfiguration is null)
                    RuntimeProtectionConfiguration = new RuntimeProtectionConfiguration();
                RuntimeProtectionConfiguration.EnforcementLevel = value;
            }
        }

        /// <summary> The configuration for use of a key vault to store secrets for later retrieval by the operator. </summary>
        public ClusterSecretArchive SecretArchive { get; set; }
        /// <summary> The settings for the secret archive used to hold credentials for the cluster. </summary>
        public SecretArchiveSettings SecretArchiveSettings { get; set; }
        /// <summary> The strategy for updating the cluster. </summary>
        public ClusterUpdateStrategy UpdateStrategy { get; set; }
        /// <summary> The settings for how security vulnerability scanning is applied to the cluster. </summary>
        internal VulnerabilityScanningSettingsPatch VulnerabilityScanningSettings { get; set; }
        /// <summary> The mode selection for container vulnerability scanning. </summary>
        public VulnerabilityScanningSettingsContainerScan? VulnerabilityScanningContainerScan
        {
            get => VulnerabilityScanningSettings is null ? default : VulnerabilityScanningSettings.ContainerScan;
            set
            {
                if (VulnerabilityScanningSettings is null)
                    VulnerabilityScanningSettings = new VulnerabilityScanningSettingsPatch();
                VulnerabilityScanningSettings.ContainerScan = value;
            }
        }
    }
}
