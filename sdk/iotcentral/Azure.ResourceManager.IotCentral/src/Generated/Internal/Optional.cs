// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.ResourceManager.IotCentral
{
    internal static class Optional
    {
        public static bool IsCollectionDefined<T>(IEnumerable<T> collection)
        {
            return !(collection is ChangeTrackingList<T> changeTrackingList && changeTrackingList.IsUndefined);
        }

        public static bool IsCollectionDefined<TKey, TValue>(IDictionary<TKey, TValue> collection)
        {
            return !(collection is ChangeTrackingDictionary<TKey, TValue> changeTrackingDictionary && changeTrackingDictionary.IsUndefined);
        }

        public static bool IsCollectionDefined<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> collection)
        {
            return !(collection is ChangeTrackingDictionary<TKey, TValue> changeTrackingDictionary && changeTrackingDictionary.IsUndefined);
        }

        public static bool IsDefined<T>(T? value)
        where T : struct
        {
            return value.HasValue;
        }

        public static bool IsDefined(object value)
        {
            return value != null;
        }

        public static bool IsDefined(JsonElement value)
        {
            return value.ValueKind != JsonValueKind.Undefined;
        }

        public static bool IsDefined(string value)
        {
            return value != null;
        }
    }
}
