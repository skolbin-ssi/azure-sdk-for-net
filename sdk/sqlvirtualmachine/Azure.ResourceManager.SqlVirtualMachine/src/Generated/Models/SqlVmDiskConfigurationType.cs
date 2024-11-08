// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Disk configuration to apply to SQL Server. </summary>
    public readonly partial struct SqlVmDiskConfigurationType : IEquatable<SqlVmDiskConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlVmDiskConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVmDiskConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "NEW";
        private const string ExtendValue = "EXTEND";
        private const string AddValue = "ADD";

        /// <summary> NEW. </summary>
        public static SqlVmDiskConfigurationType New { get; } = new SqlVmDiskConfigurationType(NewValue);
        /// <summary> EXTEND. </summary>
        public static SqlVmDiskConfigurationType Extend { get; } = new SqlVmDiskConfigurationType(ExtendValue);
        /// <summary> ADD. </summary>
        public static SqlVmDiskConfigurationType Add { get; } = new SqlVmDiskConfigurationType(AddValue);
        /// <summary> Determines if two <see cref="SqlVmDiskConfigurationType"/> values are the same. </summary>
        public static bool operator ==(SqlVmDiskConfigurationType left, SqlVmDiskConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVmDiskConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(SqlVmDiskConfigurationType left, SqlVmDiskConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlVmDiskConfigurationType"/>. </summary>
        public static implicit operator SqlVmDiskConfigurationType(string value) => new SqlVmDiskConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVmDiskConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVmDiskConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
