// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The security family provisioning State. </summary>
    public readonly partial struct SecurityFamilyProvisioningState : IEquatable<SecurityFamilyProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityFamilyProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityFamilyProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static SecurityFamilyProvisioningState Succeeded { get; } = new SecurityFamilyProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SecurityFamilyProvisioningState Failed { get; } = new SecurityFamilyProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static SecurityFamilyProvisioningState Updating { get; } = new SecurityFamilyProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="SecurityFamilyProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SecurityFamilyProvisioningState left, SecurityFamilyProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityFamilyProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SecurityFamilyProvisioningState left, SecurityFamilyProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityFamilyProvisioningState"/>. </summary>
        public static implicit operator SecurityFamilyProvisioningState(string value) => new SecurityFamilyProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityFamilyProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityFamilyProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
