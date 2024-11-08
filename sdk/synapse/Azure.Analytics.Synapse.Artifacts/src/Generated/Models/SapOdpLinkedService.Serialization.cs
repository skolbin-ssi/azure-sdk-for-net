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
    [JsonConverter(typeof(SapOdpLinkedServiceConverter))]
    public partial class SapOdpLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                writer.WriteObjectValue<object>(Server);
            }
            if (Optional.IsDefined(SystemNumber))
            {
                writer.WritePropertyName("systemNumber"u8);
                writer.WriteObjectValue<object>(SystemNumber);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteObjectValue<object>(ClientId);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteObjectValue<object>(Language);
            }
            if (Optional.IsDefined(SystemId))
            {
                writer.WritePropertyName("systemId"u8);
                writer.WriteObjectValue<object>(SystemId);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteObjectValue<object>(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(MessageServer))
            {
                writer.WritePropertyName("messageServer"u8);
                writer.WriteObjectValue<object>(MessageServer);
            }
            if (Optional.IsDefined(MessageServerService))
            {
                writer.WritePropertyName("messageServerService"u8);
                writer.WriteObjectValue<object>(MessageServerService);
            }
            if (Optional.IsDefined(SncMode))
            {
                writer.WritePropertyName("sncMode"u8);
                writer.WriteObjectValue<object>(SncMode);
            }
            if (Optional.IsDefined(SncMyName))
            {
                writer.WritePropertyName("sncMyName"u8);
                writer.WriteObjectValue<object>(SncMyName);
            }
            if (Optional.IsDefined(SncPartnerName))
            {
                writer.WritePropertyName("sncPartnerName"u8);
                writer.WriteObjectValue<object>(SncPartnerName);
            }
            if (Optional.IsDefined(SncLibraryPath))
            {
                writer.WritePropertyName("sncLibraryPath"u8);
                writer.WriteObjectValue<object>(SncLibraryPath);
            }
            if (Optional.IsDefined(SncQop))
            {
                writer.WritePropertyName("sncQop"u8);
                writer.WriteObjectValue<object>(SncQop);
            }
            if (Optional.IsDefined(X509CertificatePath))
            {
                writer.WritePropertyName("x509CertificatePath"u8);
                writer.WriteObjectValue<object>(X509CertificatePath);
            }
            if (Optional.IsDefined(LogonGroup))
            {
                writer.WritePropertyName("logonGroup"u8);
                writer.WriteObjectValue<object>(LogonGroup);
            }
            if (Optional.IsDefined(SubscriberName))
            {
                writer.WritePropertyName("subscriberName"u8);
                writer.WriteObjectValue<object>(SubscriberName);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue<object>(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SapOdpLinkedService DeserializeSapOdpLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object server = default;
            object systemNumber = default;
            object clientId = default;
            object language = default;
            object systemId = default;
            object userName = default;
            SecretBase password = default;
            object messageServer = default;
            object messageServerService = default;
            object sncMode = default;
            object sncMyName = default;
            object sncPartnerName = default;
            object sncLibraryPath = default;
            object sncQop = default;
            object x509CertificatePath = default;
            object logonGroup = default;
            object subscriberName = default;
            object encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
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
                        if (property0.NameEquals("server"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            server = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemNumber"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemNumber = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            language = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageServer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageServer = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("messageServerService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageServerService = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMyName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncMyName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncPartnerName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncPartnerName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncLibraryPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncLibraryPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncQop"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncQop = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("x509CertificatePath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            x509CertificatePath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("logonGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logonGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("subscriberName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriberName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapOdpLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                server,
                systemNumber,
                clientId,
                language,
                systemId,
                userName,
                password,
                messageServer,
                messageServerService,
                sncMode,
                sncMyName,
                sncPartnerName,
                sncLibraryPath,
                sncQop,
                x509CertificatePath,
                logonGroup,
                subscriberName,
                encryptedCredential);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new SapOdpLinkedService FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSapOdpLinkedService(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SapOdpLinkedServiceConverter : JsonConverter<SapOdpLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, SapOdpLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SapOdpLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapOdpLinkedService(document.RootElement);
            }
        }
    }
}
