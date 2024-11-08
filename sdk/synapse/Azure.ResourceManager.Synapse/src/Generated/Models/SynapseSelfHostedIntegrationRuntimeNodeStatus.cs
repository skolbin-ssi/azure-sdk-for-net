// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Status of the integration runtime node. </summary>
    public readonly partial struct SynapseSelfHostedIntegrationRuntimeNodeStatus : IEquatable<SynapseSelfHostedIntegrationRuntimeNodeStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseSelfHostedIntegrationRuntimeNodeStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseSelfHostedIntegrationRuntimeNodeStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeedRegistrationValue = "NeedRegistration";
        private const string OnlineValue = "Online";
        private const string LimitedValue = "Limited";
        private const string OfflineValue = "Offline";
        private const string UpgradingValue = "Upgrading";
        private const string InitializingValue = "Initializing";
        private const string InitializeFailedValue = "InitializeFailed";

        /// <summary> NeedRegistration. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus NeedRegistration { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(NeedRegistrationValue);
        /// <summary> Online. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus Online { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(OnlineValue);
        /// <summary> Limited. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus Limited { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(LimitedValue);
        /// <summary> Offline. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus Offline { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(OfflineValue);
        /// <summary> Upgrading. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus Upgrading { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(UpgradingValue);
        /// <summary> Initializing. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus Initializing { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(InitializingValue);
        /// <summary> InitializeFailed. </summary>
        public static SynapseSelfHostedIntegrationRuntimeNodeStatus InitializeFailed { get; } = new SynapseSelfHostedIntegrationRuntimeNodeStatus(InitializeFailedValue);
        /// <summary> Determines if two <see cref="SynapseSelfHostedIntegrationRuntimeNodeStatus"/> values are the same. </summary>
        public static bool operator ==(SynapseSelfHostedIntegrationRuntimeNodeStatus left, SynapseSelfHostedIntegrationRuntimeNodeStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseSelfHostedIntegrationRuntimeNodeStatus"/> values are not the same. </summary>
        public static bool operator !=(SynapseSelfHostedIntegrationRuntimeNodeStatus left, SynapseSelfHostedIntegrationRuntimeNodeStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseSelfHostedIntegrationRuntimeNodeStatus"/>. </summary>
        public static implicit operator SynapseSelfHostedIntegrationRuntimeNodeStatus(string value) => new SynapseSelfHostedIntegrationRuntimeNodeStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseSelfHostedIntegrationRuntimeNodeStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseSelfHostedIntegrationRuntimeNodeStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
