// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Resource status of the origin group. </summary>
    public readonly partial struct OriginGroupResourceState : IEquatable<OriginGroupResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OriginGroupResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OriginGroupResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string ActiveValue = "Active";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static OriginGroupResourceState Creating { get; } = new OriginGroupResourceState(CreatingValue);
        /// <summary> Active. </summary>
        public static OriginGroupResourceState Active { get; } = new OriginGroupResourceState(ActiveValue);
        /// <summary> Deleting. </summary>
        public static OriginGroupResourceState Deleting { get; } = new OriginGroupResourceState(DeletingValue);
        /// <summary> Determines if two <see cref="OriginGroupResourceState"/> values are the same. </summary>
        public static bool operator ==(OriginGroupResourceState left, OriginGroupResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OriginGroupResourceState"/> values are not the same. </summary>
        public static bool operator !=(OriginGroupResourceState left, OriginGroupResourceState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OriginGroupResourceState"/>. </summary>
        public static implicit operator OriginGroupResourceState(string value) => new OriginGroupResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OriginGroupResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OriginGroupResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
