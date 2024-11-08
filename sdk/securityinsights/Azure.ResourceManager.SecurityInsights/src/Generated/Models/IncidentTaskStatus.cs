// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The IncidentTaskStatus. </summary>
    public readonly partial struct IncidentTaskStatus : IEquatable<IncidentTaskStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IncidentTaskStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IncidentTaskStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "New";
        private const string CompletedValue = "Completed";

        /// <summary> A new task. </summary>
        public static IncidentTaskStatus New { get; } = new IncidentTaskStatus(NewValue);
        /// <summary> A completed task. </summary>
        public static IncidentTaskStatus Completed { get; } = new IncidentTaskStatus(CompletedValue);
        /// <summary> Determines if two <see cref="IncidentTaskStatus"/> values are the same. </summary>
        public static bool operator ==(IncidentTaskStatus left, IncidentTaskStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IncidentTaskStatus"/> values are not the same. </summary>
        public static bool operator !=(IncidentTaskStatus left, IncidentTaskStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IncidentTaskStatus"/>. </summary>
        public static implicit operator IncidentTaskStatus(string value) => new IncidentTaskStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IncidentTaskStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IncidentTaskStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
