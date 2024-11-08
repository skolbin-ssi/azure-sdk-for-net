// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Update settings of OneAgent. </summary>
    public readonly partial struct DynatraceOneAgentAutoUpdateSetting : IEquatable<DynatraceOneAgentAutoUpdateSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynatraceOneAgentAutoUpdateSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynatraceOneAgentAutoUpdateSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "ENABLED";
        private const string DisabledValue = "DISABLED";

        /// <summary> ENABLED. </summary>
        public static DynatraceOneAgentAutoUpdateSetting Enabled { get; } = new DynatraceOneAgentAutoUpdateSetting(EnabledValue);
        /// <summary> DISABLED. </summary>
        public static DynatraceOneAgentAutoUpdateSetting Disabled { get; } = new DynatraceOneAgentAutoUpdateSetting(DisabledValue);
        /// <summary> Determines if two <see cref="DynatraceOneAgentAutoUpdateSetting"/> values are the same. </summary>
        public static bool operator ==(DynatraceOneAgentAutoUpdateSetting left, DynatraceOneAgentAutoUpdateSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynatraceOneAgentAutoUpdateSetting"/> values are not the same. </summary>
        public static bool operator !=(DynatraceOneAgentAutoUpdateSetting left, DynatraceOneAgentAutoUpdateSetting right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DynatraceOneAgentAutoUpdateSetting"/>. </summary>
        public static implicit operator DynatraceOneAgentAutoUpdateSetting(string value) => new DynatraceOneAgentAutoUpdateSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynatraceOneAgentAutoUpdateSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynatraceOneAgentAutoUpdateSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
