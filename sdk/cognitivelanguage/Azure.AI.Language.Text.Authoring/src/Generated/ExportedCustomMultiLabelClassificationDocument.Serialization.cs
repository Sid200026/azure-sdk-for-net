// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class ExportedCustomMultiLabelClassificationDocument : IUtf8JsonSerializable, IJsonModel<ExportedCustomMultiLabelClassificationDocument>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportedCustomMultiLabelClassificationDocument>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportedCustomMultiLabelClassificationDocument>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomMultiLabelClassificationDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedCustomMultiLabelClassificationDocument)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Classes))
            {
                writer.WritePropertyName("classes"u8);
                writer.WriteStartArray();
                foreach (var item in Classes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteStringValue(Dataset);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExportedCustomMultiLabelClassificationDocument IJsonModel<ExportedCustomMultiLabelClassificationDocument>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomMultiLabelClassificationDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedCustomMultiLabelClassificationDocument)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportedCustomMultiLabelClassificationDocument(document.RootElement, options);
        }

        internal static ExportedCustomMultiLabelClassificationDocument DeserializeExportedCustomMultiLabelClassificationDocument(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExportedDocumentClass> classes = default;
            string location = default;
            string language = default;
            string dataset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExportedDocumentClass> array = new List<ExportedDocumentClass>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExportedDocumentClass.DeserializeExportedDocumentClass(item, options));
                    }
                    classes = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    dataset = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportedCustomMultiLabelClassificationDocument(classes ?? new ChangeTrackingList<ExportedDocumentClass>(), location, language, dataset, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportedCustomMultiLabelClassificationDocument>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomMultiLabelClassificationDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExportedCustomMultiLabelClassificationDocument)} does not support writing '{options.Format}' format.");
            }
        }

        ExportedCustomMultiLabelClassificationDocument IPersistableModel<ExportedCustomMultiLabelClassificationDocument>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomMultiLabelClassificationDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExportedCustomMultiLabelClassificationDocument(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportedCustomMultiLabelClassificationDocument)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportedCustomMultiLabelClassificationDocument>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExportedCustomMultiLabelClassificationDocument FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeExportedCustomMultiLabelClassificationDocument(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
