// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class TextAnalyticsWarning
    {
        internal static TextAnalyticsWarning DeserializeTextAnalyticsWarning(JsonElement element)
        {
            WarningCodeValue code = default;
            string message = default;
            Optional<string> targetRef = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = new WarningCodeValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetRef"))
                {
                    targetRef = property.Value.GetString();
                    continue;
                }
            }
            return new TextAnalyticsWarning(code, message, targetRef.Value);
        }
    }
}
