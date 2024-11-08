// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class RepositoryWriteableProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CanDelete))
            {
                writer.WritePropertyName("deleteEnabled"u8);
                writer.WriteBooleanValue(CanDelete.Value);
            }
            if (Optional.IsDefined(CanWrite))
            {
                writer.WritePropertyName("writeEnabled"u8);
                writer.WriteBooleanValue(CanWrite.Value);
            }
            if (Optional.IsDefined(CanList))
            {
                writer.WritePropertyName("listEnabled"u8);
                writer.WriteBooleanValue(CanList.Value);
            }
            if (Optional.IsDefined(CanRead))
            {
                writer.WritePropertyName("readEnabled"u8);
                writer.WriteBooleanValue(CanRead.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
