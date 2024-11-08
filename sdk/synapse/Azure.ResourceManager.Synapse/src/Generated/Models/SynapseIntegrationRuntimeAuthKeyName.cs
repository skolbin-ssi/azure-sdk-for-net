// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The name of the authentication key to regenerate. </summary>
    public readonly partial struct SynapseIntegrationRuntimeAuthKeyName : IEquatable<SynapseIntegrationRuntimeAuthKeyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeAuthKeyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseIntegrationRuntimeAuthKeyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuthKey1Value = "authKey1";
        private const string AuthKey2Value = "authKey2";

        /// <summary> authKey1. </summary>
        public static SynapseIntegrationRuntimeAuthKeyName AuthKey1 { get; } = new SynapseIntegrationRuntimeAuthKeyName(AuthKey1Value);
        /// <summary> authKey2. </summary>
        public static SynapseIntegrationRuntimeAuthKeyName AuthKey2 { get; } = new SynapseIntegrationRuntimeAuthKeyName(AuthKey2Value);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeAuthKeyName"/> values are the same. </summary>
        public static bool operator ==(SynapseIntegrationRuntimeAuthKeyName left, SynapseIntegrationRuntimeAuthKeyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeAuthKeyName"/> values are not the same. </summary>
        public static bool operator !=(SynapseIntegrationRuntimeAuthKeyName left, SynapseIntegrationRuntimeAuthKeyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseIntegrationRuntimeAuthKeyName"/>. </summary>
        public static implicit operator SynapseIntegrationRuntimeAuthKeyName(string value) => new SynapseIntegrationRuntimeAuthKeyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseIntegrationRuntimeAuthKeyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseIntegrationRuntimeAuthKeyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
