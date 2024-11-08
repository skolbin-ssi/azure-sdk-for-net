// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Secure Score of Backup Vault. </summary>
    public readonly partial struct BackupVaultSecureScoreLevel : IEquatable<BackupVaultSecureScoreLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupVaultSecureScoreLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupVaultSecureScoreLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MinimumValue = "Minimum";
        private const string AdequateValue = "Adequate";
        private const string MaximumValue = "Maximum";
        private const string NotSupportedValue = "NotSupported";

        /// <summary> None. </summary>
        public static BackupVaultSecureScoreLevel None { get; } = new BackupVaultSecureScoreLevel(NoneValue);
        /// <summary> Minimum. </summary>
        public static BackupVaultSecureScoreLevel Minimum { get; } = new BackupVaultSecureScoreLevel(MinimumValue);
        /// <summary> Adequate. </summary>
        public static BackupVaultSecureScoreLevel Adequate { get; } = new BackupVaultSecureScoreLevel(AdequateValue);
        /// <summary> Maximum. </summary>
        public static BackupVaultSecureScoreLevel Maximum { get; } = new BackupVaultSecureScoreLevel(MaximumValue);
        /// <summary> NotSupported. </summary>
        public static BackupVaultSecureScoreLevel NotSupported { get; } = new BackupVaultSecureScoreLevel(NotSupportedValue);
        /// <summary> Determines if two <see cref="BackupVaultSecureScoreLevel"/> values are the same. </summary>
        public static bool operator ==(BackupVaultSecureScoreLevel left, BackupVaultSecureScoreLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupVaultSecureScoreLevel"/> values are not the same. </summary>
        public static bool operator !=(BackupVaultSecureScoreLevel left, BackupVaultSecureScoreLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BackupVaultSecureScoreLevel"/>. </summary>
        public static implicit operator BackupVaultSecureScoreLevel(string value) => new BackupVaultSecureScoreLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupVaultSecureScoreLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupVaultSecureScoreLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
