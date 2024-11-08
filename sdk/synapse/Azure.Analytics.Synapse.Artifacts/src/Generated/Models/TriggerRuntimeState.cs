// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Enumerates possible state of Triggers. </summary>
    public readonly partial struct TriggerRuntimeState : IEquatable<TriggerRuntimeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TriggerRuntimeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TriggerRuntimeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartedValue = "Started";
        private const string StoppedValue = "Stopped";
        private const string DisabledValue = "Disabled";

        /// <summary> Started. </summary>
        public static TriggerRuntimeState Started { get; } = new TriggerRuntimeState(StartedValue);
        /// <summary> Stopped. </summary>
        public static TriggerRuntimeState Stopped { get; } = new TriggerRuntimeState(StoppedValue);
        /// <summary> Disabled. </summary>
        public static TriggerRuntimeState Disabled { get; } = new TriggerRuntimeState(DisabledValue);
        /// <summary> Determines if two <see cref="TriggerRuntimeState"/> values are the same. </summary>
        public static bool operator ==(TriggerRuntimeState left, TriggerRuntimeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TriggerRuntimeState"/> values are not the same. </summary>
        public static bool operator !=(TriggerRuntimeState left, TriggerRuntimeState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TriggerRuntimeState"/>. </summary>
        public static implicit operator TriggerRuntimeState(string value) => new TriggerRuntimeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TriggerRuntimeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TriggerRuntimeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
