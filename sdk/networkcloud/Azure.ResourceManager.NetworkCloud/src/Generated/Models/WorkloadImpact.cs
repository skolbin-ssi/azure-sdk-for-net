// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The indicator of whether the workload will be impacted during the upgrade. </summary>
    public readonly partial struct WorkloadImpact : IEquatable<WorkloadImpact>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadImpact"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadImpact(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static WorkloadImpact True { get; } = new WorkloadImpact(TrueValue);
        /// <summary> False. </summary>
        public static WorkloadImpact False { get; } = new WorkloadImpact(FalseValue);
        /// <summary> Determines if two <see cref="WorkloadImpact"/> values are the same. </summary>
        public static bool operator ==(WorkloadImpact left, WorkloadImpact right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadImpact"/> values are not the same. </summary>
        public static bool operator !=(WorkloadImpact left, WorkloadImpact right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WorkloadImpact"/>. </summary>
        public static implicit operator WorkloadImpact(string value) => new WorkloadImpact(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadImpact other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadImpact other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
