// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Azure Key Vault key management service settings for the security profile.
/// </summary>
public partial class ManagedClusterSecurityProfileKeyVaultKms : ProvisionableConstruct
{
    /// <summary>
    /// Whether to enable Azure Key Vault key management service. The default
    /// is false.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Identifier of Azure Key Vault key. See [key identifier
    /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
    /// for more details. When Azure Key Vault key management service is
    /// enabled, this field is required and must be a valid key identifier.
    /// When Azure Key Vault key management service is disabled, leave the
    /// field empty.
    /// </summary>
    public BicepValue<string> KeyId 
    {
        get { Initialize(); return _keyId!; }
        set { Initialize(); _keyId!.Assign(value); }
    }
    private BicepValue<string>? _keyId;

    /// <summary>
    /// Network access of key vault. The possible values are `Public` and
    /// `Private`. `Public` means the key vault allows public access from all
    /// networks. `Private` means the key vault disables public access and
    /// enables private link. The default value is `Public`.
    /// </summary>
    public BicepValue<ManagedClusterKeyVaultNetworkAccessType> KeyVaultNetworkAccess 
    {
        get { Initialize(); return _keyVaultNetworkAccess!; }
        set { Initialize(); _keyVaultNetworkAccess!.Assign(value); }
    }
    private BicepValue<ManagedClusterKeyVaultNetworkAccessType>? _keyVaultNetworkAccess;

    /// <summary>
    /// Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this
    /// field is required and must be a valid resource ID. When
    /// keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    public BicepValue<ResourceIdentifier> KeyVaultResourceId 
    {
        get { Initialize(); return _keyVaultResourceId!; }
        set { Initialize(); _keyVaultResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _keyVaultResourceId;

    /// <summary>
    /// Creates a new ManagedClusterSecurityProfileKeyVaultKms.
    /// </summary>
    public ManagedClusterSecurityProfileKeyVaultKms()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterSecurityProfileKeyVaultKms.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _keyId = DefineProperty<string>("KeyId", ["keyId"]);
        _keyVaultNetworkAccess = DefineProperty<ManagedClusterKeyVaultNetworkAccessType>("KeyVaultNetworkAccess", ["keyVaultNetworkAccess"]);
        _keyVaultResourceId = DefineProperty<ResourceIdentifier>("KeyVaultResourceId", ["keyVaultResourceId"]);
    }
}
