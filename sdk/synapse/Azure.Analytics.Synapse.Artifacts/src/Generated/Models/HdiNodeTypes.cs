// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> All available HdiNodeTypes values. </summary>
    internal readonly partial struct HdiNodeTypes : IEquatable<HdiNodeTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HdiNodeTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HdiNodeTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HeadnodeValue = "Headnode";
        private const string WorkernodeValue = "Workernode";
        private const string ZookeeperValue = "Zookeeper";

        /// <summary> Headnode. </summary>
        public static HdiNodeTypes Headnode { get; } = new HdiNodeTypes(HeadnodeValue);
        /// <summary> Workernode. </summary>
        public static HdiNodeTypes Workernode { get; } = new HdiNodeTypes(WorkernodeValue);
        /// <summary> Zookeeper. </summary>
        public static HdiNodeTypes Zookeeper { get; } = new HdiNodeTypes(ZookeeperValue);
        /// <summary> Determines if two <see cref="HdiNodeTypes"/> values are the same. </summary>
        public static bool operator ==(HdiNodeTypes left, HdiNodeTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HdiNodeTypes"/> values are not the same. </summary>
        public static bool operator !=(HdiNodeTypes left, HdiNodeTypes right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HdiNodeTypes"/>. </summary>
        public static implicit operator HdiNodeTypes(string value) => new HdiNodeTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HdiNodeTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HdiNodeTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
