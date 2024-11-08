// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The ParquetCompressionCodecEnum. </summary>
    internal readonly partial struct ParquetCompressionCodecEnum : IEquatable<ParquetCompressionCodecEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ParquetCompressionCodecEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ParquetCompressionCodecEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string GzipValue = "gzip";
        private const string SnappyValue = "snappy";
        private const string LzoValue = "lzo";

        /// <summary> none. </summary>
        public static ParquetCompressionCodecEnum None { get; } = new ParquetCompressionCodecEnum(NoneValue);
        /// <summary> gzip. </summary>
        public static ParquetCompressionCodecEnum Gzip { get; } = new ParquetCompressionCodecEnum(GzipValue);
        /// <summary> snappy. </summary>
        public static ParquetCompressionCodecEnum Snappy { get; } = new ParquetCompressionCodecEnum(SnappyValue);
        /// <summary> lzo. </summary>
        public static ParquetCompressionCodecEnum Lzo { get; } = new ParquetCompressionCodecEnum(LzoValue);
        /// <summary> Determines if two <see cref="ParquetCompressionCodecEnum"/> values are the same. </summary>
        public static bool operator ==(ParquetCompressionCodecEnum left, ParquetCompressionCodecEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ParquetCompressionCodecEnum"/> values are not the same. </summary>
        public static bool operator !=(ParquetCompressionCodecEnum left, ParquetCompressionCodecEnum right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ParquetCompressionCodecEnum"/>. </summary>
        public static implicit operator ParquetCompressionCodecEnum(string value) => new ParquetCompressionCodecEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ParquetCompressionCodecEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ParquetCompressionCodecEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
