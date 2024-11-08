// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The ThreatIntelligenceType. </summary>
    public readonly partial struct ThreatIntelligenceType : IEquatable<ThreatIntelligenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThreatIntelligenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MainValue = "main";

        /// <summary> main. </summary>
        public static ThreatIntelligenceType Main { get; } = new ThreatIntelligenceType(MainValue);
        /// <summary> Determines if two <see cref="ThreatIntelligenceType"/> values are the same. </summary>
        public static bool operator ==(ThreatIntelligenceType left, ThreatIntelligenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThreatIntelligenceType"/> values are not the same. </summary>
        public static bool operator !=(ThreatIntelligenceType left, ThreatIntelligenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ThreatIntelligenceType"/>. </summary>
        public static implicit operator ThreatIntelligenceType(string value) => new ThreatIntelligenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThreatIntelligenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThreatIntelligenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
