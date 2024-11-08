// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents the assignment type of the offering. </summary>
    public readonly partial struct PhoneNumberAssignmentType : IEquatable<PhoneNumberAssignmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberAssignmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberAssignmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PersonValue = "person";
        private const string ApplicationValue = "application";

        /// <summary> person. </summary>
        public static PhoneNumberAssignmentType Person { get; } = new PhoneNumberAssignmentType(PersonValue);
        /// <summary> application. </summary>
        public static PhoneNumberAssignmentType Application { get; } = new PhoneNumberAssignmentType(ApplicationValue);
        /// <summary> Determines if two <see cref="PhoneNumberAssignmentType"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberAssignmentType left, PhoneNumberAssignmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberAssignmentType"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberAssignmentType left, PhoneNumberAssignmentType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PhoneNumberAssignmentType"/>. </summary>
        public static implicit operator PhoneNumberAssignmentType(string value) => new PhoneNumberAssignmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberAssignmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberAssignmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
