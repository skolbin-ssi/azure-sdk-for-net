// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkErrorSource. </summary>
    public readonly partial struct SparkErrorSource : IEquatable<SparkErrorSource>
    {
        private readonly string _value;

        private const string SystemErrorValue = "System";
        private const string UserErrorValue = "User";
        private const string UnknownErrorValue = "Unknown";
        private const string DependencyErrorValue = "Dependency";
        /// <summary> Determines if two <see cref="SparkErrorSource"/> values are the same. </summary>
        public static bool operator ==(SparkErrorSource left, SparkErrorSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkErrorSource"/> values are not the same. </summary>
        public static bool operator !=(SparkErrorSource left, SparkErrorSource right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SparkErrorSource"/>. </summary>
        public static implicit operator SparkErrorSource(string value) => new SparkErrorSource(value);
    }
}
