// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningFeatureStoreEntityContainerResource : IJsonModel<MachineLearningFeatureStoreEntityContainerData>
    {
        void IJsonModel<MachineLearningFeatureStoreEntityContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeatureStoreEntityContainerData>)Data).Write(writer, options);

        MachineLearningFeatureStoreEntityContainerData IJsonModel<MachineLearningFeatureStoreEntityContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeatureStoreEntityContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningFeatureStoreEntityContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningFeatureStoreEntityContainerData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningFeatureStoreEntityContainerData IPersistableModel<MachineLearningFeatureStoreEntityContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningFeatureStoreEntityContainerData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningFeatureStoreEntityContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningFeatureStoreEntityContainerData>)Data).GetFormatFromOptions(options);
    }
}
