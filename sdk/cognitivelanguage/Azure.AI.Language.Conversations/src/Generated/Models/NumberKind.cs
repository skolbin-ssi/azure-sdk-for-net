// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The type of the extracted number entity. </summary>
    public readonly partial struct NumberKind : IEquatable<NumberKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NumberKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NumberKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegerValue = "Integer";
        private const string DecimalValue = "Decimal";
        private const string PowerValue = "Power";
        private const string FractionValue = "Fraction";
        private const string PercentValue = "Percent";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary> Integer number. </summary>
        public static NumberKind Integer { get; } = new NumberKind(IntegerValue);
        /// <summary> Decimal number. </summary>
        public static NumberKind Decimal { get; } = new NumberKind(DecimalValue);
        /// <summary> Power number. </summary>
        public static NumberKind Power { get; } = new NumberKind(PowerValue);
        /// <summary> Fraction number. </summary>
        public static NumberKind Fraction { get; } = new NumberKind(FractionValue);
        /// <summary> Percent number. </summary>
        public static NumberKind Percent { get; } = new NumberKind(PercentValue);
        /// <summary> Unspecified number kind. </summary>
        public static NumberKind Unspecified { get; } = new NumberKind(UnspecifiedValue);
        /// <summary> Determines if two <see cref="NumberKind"/> values are the same. </summary>
        public static bool operator ==(NumberKind left, NumberKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NumberKind"/> values are not the same. </summary>
        public static bool operator !=(NumberKind left, NumberKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NumberKind"/>. </summary>
        public static implicit operator NumberKind(string value) => new NumberKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NumberKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NumberKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
