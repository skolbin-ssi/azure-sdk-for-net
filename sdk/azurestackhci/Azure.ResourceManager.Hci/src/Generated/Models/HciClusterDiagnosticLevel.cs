// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Desired level of diagnostic data emitted by the cluster. </summary>
    public readonly partial struct HciClusterDiagnosticLevel : IEquatable<HciClusterDiagnosticLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciClusterDiagnosticLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciClusterDiagnosticLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OffValue = "Off";
        private const string BasicValue = "Basic";
        private const string EnhancedValue = "Enhanced";

        /// <summary> Off. </summary>
        public static HciClusterDiagnosticLevel Off { get; } = new HciClusterDiagnosticLevel(OffValue);
        /// <summary> Basic. </summary>
        public static HciClusterDiagnosticLevel Basic { get; } = new HciClusterDiagnosticLevel(BasicValue);
        /// <summary> Enhanced. </summary>
        public static HciClusterDiagnosticLevel Enhanced { get; } = new HciClusterDiagnosticLevel(EnhancedValue);
        /// <summary> Determines if two <see cref="HciClusterDiagnosticLevel"/> values are the same. </summary>
        public static bool operator ==(HciClusterDiagnosticLevel left, HciClusterDiagnosticLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciClusterDiagnosticLevel"/> values are not the same. </summary>
        public static bool operator !=(HciClusterDiagnosticLevel left, HciClusterDiagnosticLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HciClusterDiagnosticLevel"/>. </summary>
        public static implicit operator HciClusterDiagnosticLevel(string value) => new HciClusterDiagnosticLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciClusterDiagnosticLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciClusterDiagnosticLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
