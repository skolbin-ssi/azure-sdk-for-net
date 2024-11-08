// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerAadAdministratorResource : IJsonModel<MySqlFlexibleServerAadAdministratorData>
    {
        void IJsonModel<MySqlFlexibleServerAadAdministratorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerAadAdministratorData>)Data).Write(writer, options);

        MySqlFlexibleServerAadAdministratorData IJsonModel<MySqlFlexibleServerAadAdministratorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerAadAdministratorData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MySqlFlexibleServerAadAdministratorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MySqlFlexibleServerAadAdministratorData IPersistableModel<MySqlFlexibleServerAadAdministratorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MySqlFlexibleServerAadAdministratorData>(data, options);

        string IPersistableModel<MySqlFlexibleServerAadAdministratorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MySqlFlexibleServerAadAdministratorData>)Data).GetFormatFromOptions(options);
    }
}
