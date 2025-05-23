// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class NfsMountEndpointUpdateProperties : IUtf8JsonSerializable, IJsonModel<NfsMountEndpointUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NfsMountEndpointUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NfsMountEndpointUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountEndpointUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsMountEndpointUpdateProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        NfsMountEndpointUpdateProperties IJsonModel<NfsMountEndpointUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountEndpointUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsMountEndpointUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNfsMountEndpointUpdateProperties(document.RootElement, options);
        }

        internal static NfsMountEndpointUpdateProperties DeserializeNfsMountEndpointUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NfsMountEndpointUpdateProperties(endpointType, description, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NfsMountEndpointUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountEndpointUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageMoverContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NfsMountEndpointUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NfsMountEndpointUpdateProperties IPersistableModel<NfsMountEndpointUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountEndpointUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNfsMountEndpointUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NfsMountEndpointUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NfsMountEndpointUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
