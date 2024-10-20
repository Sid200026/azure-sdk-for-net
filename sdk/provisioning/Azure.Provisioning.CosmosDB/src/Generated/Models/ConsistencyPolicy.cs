// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The consistency policy for the Cosmos DB database account.
/// </summary>
public partial class ConsistencyPolicy : ProvisionableConstruct
{
    /// <summary>
    /// The default consistency level and configuration settings of the Cosmos
    /// DB account.
    /// </summary>
    public BicepValue<DefaultConsistencyLevel> DefaultConsistencyLevel { get => _defaultConsistencyLevel; set => _defaultConsistencyLevel.Assign(value); }
    private readonly BicepValue<DefaultConsistencyLevel> _defaultConsistencyLevel;

    /// <summary>
    /// When used with the Bounded Staleness consistency level, this value
    /// represents the number of stale requests tolerated. Accepted range for
    /// this value is 1 – 2,147,483,647. Required when
    /// defaultConsistencyPolicy is set to &apos;BoundedStaleness&apos;.
    /// </summary>
    public BicepValue<long> MaxStalenessPrefix { get => _maxStalenessPrefix; set => _maxStalenessPrefix.Assign(value); }
    private readonly BicepValue<long> _maxStalenessPrefix;

    /// <summary>
    /// When used with the Bounded Staleness consistency level, this value
    /// represents the time amount of staleness (in seconds) tolerated.
    /// Accepted range for this value is 5 - 86400. Required when
    /// defaultConsistencyPolicy is set to &apos;BoundedStaleness&apos;.
    /// </summary>
    public BicepValue<int> MaxIntervalInSeconds { get => _maxIntervalInSeconds; set => _maxIntervalInSeconds.Assign(value); }
    private readonly BicepValue<int> _maxIntervalInSeconds;

    /// <summary>
    /// Creates a new ConsistencyPolicy.
    /// </summary>
    public ConsistencyPolicy()
    {
        _defaultConsistencyLevel = BicepValue<DefaultConsistencyLevel>.DefineProperty(this, "DefaultConsistencyLevel", ["defaultConsistencyLevel"]);
        _maxStalenessPrefix = BicepValue<long>.DefineProperty(this, "MaxStalenessPrefix", ["maxStalenessPrefix"]);
        _maxIntervalInSeconds = BicepValue<int>.DefineProperty(this, "MaxIntervalInSeconds", ["maxIntervalInSeconds"]);
    }
}
