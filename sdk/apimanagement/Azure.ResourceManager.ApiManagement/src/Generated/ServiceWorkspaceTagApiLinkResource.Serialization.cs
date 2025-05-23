// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceTagApiLinkResource : IJsonModel<TagApiLinkContractData>
    {
        void IJsonModel<TagApiLinkContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TagApiLinkContractData>)Data).Write(writer, options);

        TagApiLinkContractData IJsonModel<TagApiLinkContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TagApiLinkContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TagApiLinkContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TagApiLinkContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        TagApiLinkContractData IPersistableModel<TagApiLinkContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TagApiLinkContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<TagApiLinkContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TagApiLinkContractData>)Data).GetFormatFromOptions(options);
    }
}
