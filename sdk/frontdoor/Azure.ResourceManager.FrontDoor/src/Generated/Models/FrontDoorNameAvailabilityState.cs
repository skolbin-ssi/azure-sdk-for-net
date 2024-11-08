// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Indicates whether the name is available. </summary>
    public readonly partial struct FrontDoorNameAvailabilityState : IEquatable<FrontDoorNameAvailabilityState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorNameAvailabilityState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorNameAvailabilityState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Available. </summary>
        public static FrontDoorNameAvailabilityState Available { get; } = new FrontDoorNameAvailabilityState(AvailableValue);
        /// <summary> Unavailable. </summary>
        public static FrontDoorNameAvailabilityState Unavailable { get; } = new FrontDoorNameAvailabilityState(UnavailableValue);
        /// <summary> Determines if two <see cref="FrontDoorNameAvailabilityState"/> values are the same. </summary>
        public static bool operator ==(FrontDoorNameAvailabilityState left, FrontDoorNameAvailabilityState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorNameAvailabilityState"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorNameAvailabilityState left, FrontDoorNameAvailabilityState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FrontDoorNameAvailabilityState"/>. </summary>
        public static implicit operator FrontDoorNameAvailabilityState(string value) => new FrontDoorNameAvailabilityState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorNameAvailabilityState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorNameAvailabilityState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
