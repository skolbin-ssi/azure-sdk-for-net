// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The status of the incident. </summary>
    public readonly partial struct SecurityInsightsIncidentStatus : IEquatable<SecurityInsightsIncidentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsIncidentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "New";
        private const string ActiveValue = "Active";
        private const string ClosedValue = "Closed";

        /// <summary> An active incident which isn't being handled currently. </summary>
        public static SecurityInsightsIncidentStatus New { get; } = new SecurityInsightsIncidentStatus(NewValue);
        /// <summary> An active incident which is being handled. </summary>
        public static SecurityInsightsIncidentStatus Active { get; } = new SecurityInsightsIncidentStatus(ActiveValue);
        /// <summary> A non-active incident. </summary>
        public static SecurityInsightsIncidentStatus Closed { get; } = new SecurityInsightsIncidentStatus(ClosedValue);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentStatus"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsIncidentStatus left, SecurityInsightsIncidentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentStatus"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsIncidentStatus left, SecurityInsightsIncidentStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityInsightsIncidentStatus"/>. </summary>
        public static implicit operator SecurityInsightsIncidentStatus(string value) => new SecurityInsightsIncidentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsIncidentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsIncidentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
