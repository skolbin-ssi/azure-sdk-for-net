// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> The UsageTypeEnum. </summary>
    public readonly partial struct UsageTypeEnum : IEquatable<UsageTypeEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UsageTypeEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UsageTypeEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisplayValue = "Display";
        private const string RouteValue = "Route";

        /// <summary> Display. </summary>
        public static UsageTypeEnum Display { get; } = new UsageTypeEnum(DisplayValue);
        /// <summary> Route. </summary>
        public static UsageTypeEnum Route { get; } = new UsageTypeEnum(RouteValue);
        /// <summary> Determines if two <see cref="UsageTypeEnum"/> values are the same. </summary>
        public static bool operator ==(UsageTypeEnum left, UsageTypeEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UsageTypeEnum"/> values are not the same. </summary>
        public static bool operator !=(UsageTypeEnum left, UsageTypeEnum right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UsageTypeEnum"/>. </summary>
        public static implicit operator UsageTypeEnum(string value) => new UsageTypeEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UsageTypeEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UsageTypeEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
