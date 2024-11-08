// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisPackageLocationConverter))]
    public partial class SsisPackageLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePath))
            {
                writer.WritePropertyName("packagePath"u8);
                writer.WriteObjectValue<object>(PackagePath);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePassword))
            {
                writer.WritePropertyName("packagePassword"u8);
                writer.WriteObjectValue(PackagePassword);
            }
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential"u8);
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(ConfigurationPath))
            {
                writer.WritePropertyName("configurationPath"u8);
                writer.WriteObjectValue<object>(ConfigurationPath);
            }
            if (Optional.IsDefined(ConfigurationAccessCredential))
            {
                writer.WritePropertyName("configurationAccessCredential"u8);
                writer.WriteObjectValue(ConfigurationAccessCredential);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageContent))
            {
                writer.WritePropertyName("packageContent"u8);
                writer.WriteObjectValue<object>(PackageContent);
            }
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            if (Optional.IsCollectionDefined(ChildPackages))
            {
                writer.WritePropertyName("childPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisPackageLocation DeserializeSsisPackageLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object packagePath = default;
            SsisPackageLocationType? type = default;
            SecretBase packagePassword = default;
            SsisAccessCredential accessCredential = default;
            object configurationPath = default;
            SsisAccessCredential configurationAccessCredential = default;
            string packageName = default;
            object packageContent = default;
            string packageLastModifiedDate = default;
            IList<SsisChildPackage> childPackages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    packagePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SsisPackageLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packagePassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packagePassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("configurationAccessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationAccessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("packageName"u8))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageContent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageContent = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("packageLastModifiedDate"u8))
                        {
                            packageLastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("childPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SsisChildPackage> array = new List<SsisChildPackage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SsisChildPackage.DeserializeSsisChildPackage(item));
                            }
                            childPackages = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisPackageLocation(
                packagePath,
                type,
                packagePassword,
                accessCredential,
                configurationPath,
                configurationAccessCredential,
                packageName,
                packageContent,
                packageLastModifiedDate,
                childPackages ?? new ChangeTrackingList<SsisChildPackage>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SsisPackageLocation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSsisPackageLocation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SsisPackageLocationConverter : JsonConverter<SsisPackageLocation>
        {
            public override void Write(Utf8JsonWriter writer, SsisPackageLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisPackageLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisPackageLocation(document.RootElement);
            }
        }
    }
}
