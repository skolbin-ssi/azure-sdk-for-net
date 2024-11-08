// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapseTransparentDataEncryptionName. </summary>
    public readonly partial struct SynapseTransparentDataEncryptionName : IEquatable<SynapseTransparentDataEncryptionName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseTransparentDataEncryptionName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseTransparentDataEncryptionName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static SynapseTransparentDataEncryptionName Current { get; } = new SynapseTransparentDataEncryptionName(CurrentValue);
        /// <summary> Determines if two <see cref="SynapseTransparentDataEncryptionName"/> values are the same. </summary>
        public static bool operator ==(SynapseTransparentDataEncryptionName left, SynapseTransparentDataEncryptionName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseTransparentDataEncryptionName"/> values are not the same. </summary>
        public static bool operator !=(SynapseTransparentDataEncryptionName left, SynapseTransparentDataEncryptionName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseTransparentDataEncryptionName"/>. </summary>
        public static implicit operator SynapseTransparentDataEncryptionName(string value) => new SynapseTransparentDataEncryptionName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseTransparentDataEncryptionName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseTransparentDataEncryptionName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
