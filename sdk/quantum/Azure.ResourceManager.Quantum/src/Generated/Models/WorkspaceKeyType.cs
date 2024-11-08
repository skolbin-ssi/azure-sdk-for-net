// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> The WorkspaceKeyType. </summary>
    public readonly partial struct WorkspaceKeyType : IEquatable<WorkspaceKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkspaceKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkspaceKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> Primary. </summary>
        public static WorkspaceKeyType Primary { get; } = new WorkspaceKeyType(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static WorkspaceKeyType Secondary { get; } = new WorkspaceKeyType(SecondaryValue);
        /// <summary> Determines if two <see cref="WorkspaceKeyType"/> values are the same. </summary>
        public static bool operator ==(WorkspaceKeyType left, WorkspaceKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkspaceKeyType"/> values are not the same. </summary>
        public static bool operator !=(WorkspaceKeyType left, WorkspaceKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WorkspaceKeyType"/>. </summary>
        public static implicit operator WorkspaceKeyType(string value) => new WorkspaceKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkspaceKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkspaceKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
