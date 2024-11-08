// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingAccountPolicyProperties : IUtf8JsonSerializable, IJsonModel<BillingAccountPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingAccountPolicyProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingAccountPolicyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAccountPolicyProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAgreementPolicies))
            {
                writer.WritePropertyName("enterpriseAgreementPolicies"u8);
                writer.WriteObjectValue(EnterpriseAgreementPolicies, options);
            }
            if (Optional.IsDefined(MarketplacePurchases))
            {
                writer.WritePropertyName("marketplacePurchases"u8);
                writer.WriteStringValue(MarketplacePurchases.Value.ToString());
            }
            if (Optional.IsDefined(ReservationPurchases))
            {
                writer.WritePropertyName("reservationPurchases"u8);
                writer.WriteStringValue(ReservationPurchases.Value.ToString());
            }
            if (Optional.IsDefined(SavingsPlanPurchases))
            {
                writer.WritePropertyName("savingsPlanPurchases"u8);
                writer.WriteStringValue(SavingsPlanPurchases.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BillingAccountPolicyProperties IJsonModel<BillingAccountPolicyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAccountPolicyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingAccountPolicyProperties(document.RootElement, options);
        }

        internal static BillingAccountPolicyProperties DeserializeBillingAccountPolicyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingProvisioningState? provisioningState = default;
            EnterpriseAgreementPolicies enterpriseAgreementPolicies = default;
            MarketplacePurchasesPolicy? marketplacePurchases = default;
            ReservationPurchasesPolicy? reservationPurchases = default;
            SavingsPlanPurchasesPolicy? savingsPlanPurchases = default;
            IList<BillingPolicySummary> policies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new BillingProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAgreementPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enterpriseAgreementPolicies = EnterpriseAgreementPolicies.DeserializeEnterpriseAgreementPolicies(property.Value, options);
                    continue;
                }
                if (property.NameEquals("marketplacePurchases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplacePurchases = new MarketplacePurchasesPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reservationPurchases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationPurchases = new ReservationPurchasesPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("savingsPlanPurchases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    savingsPlanPurchases = new SavingsPlanPurchasesPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingPolicySummary> array = new List<BillingPolicySummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingPolicySummary.DeserializeBillingPolicySummary(item, options));
                    }
                    policies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingAccountPolicyProperties(
                provisioningState,
                enterpriseAgreementPolicies,
                marketplacePurchases,
                reservationPurchases,
                savingsPlanPurchases,
                policies ?? new ChangeTrackingList<BillingPolicySummary>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnterpriseAgreementPolicies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enterpriseAgreementPolicies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnterpriseAgreementPolicies))
                {
                    builder.Append("  enterpriseAgreementPolicies: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EnterpriseAgreementPolicies, options, 2, false, "  enterpriseAgreementPolicies: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MarketplacePurchases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  marketplacePurchases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MarketplacePurchases))
                {
                    builder.Append("  marketplacePurchases: ");
                    builder.AppendLine($"'{MarketplacePurchases.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReservationPurchases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reservationPurchases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReservationPurchases))
                {
                    builder.Append("  reservationPurchases: ");
                    builder.AppendLine($"'{ReservationPurchases.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SavingsPlanPurchases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  savingsPlanPurchases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SavingsPlanPurchases))
                {
                    builder.Append("  savingsPlanPurchases: ");
                    builder.AppendLine($"'{SavingsPlanPurchases.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Policies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  policies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Policies))
                {
                    if (Policies.Any())
                    {
                        builder.Append("  policies: ");
                        builder.AppendLine("[");
                        foreach (var item in Policies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  policies: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingAccountPolicyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingAccountPolicyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BillingAccountPolicyProperties IPersistableModel<BillingAccountPolicyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingAccountPolicyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingAccountPolicyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingAccountPolicyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
