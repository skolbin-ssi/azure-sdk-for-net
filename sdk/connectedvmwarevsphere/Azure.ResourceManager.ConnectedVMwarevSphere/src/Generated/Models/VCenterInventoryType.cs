// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> The inventory type. </summary>
    public readonly partial struct VCenterInventoryType : IEquatable<VCenterInventoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VCenterInventoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VCenterInventoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResourcePoolValue = "ResourcePool";
        private const string VirtualMachineValue = "VirtualMachine";
        private const string VirtualMachineTemplateValue = "VirtualMachineTemplate";
        private const string VirtualNetworkValue = "VirtualNetwork";
        private const string ClusterValue = "Cluster";
        private const string DatastoreValue = "Datastore";
        private const string HostValue = "Host";

        /// <summary> ResourcePool. </summary>
        public static VCenterInventoryType ResourcePool { get; } = new VCenterInventoryType(ResourcePoolValue);
        /// <summary> VirtualMachine. </summary>
        public static VCenterInventoryType VirtualMachine { get; } = new VCenterInventoryType(VirtualMachineValue);
        /// <summary> VirtualMachineTemplate. </summary>
        public static VCenterInventoryType VirtualMachineTemplate { get; } = new VCenterInventoryType(VirtualMachineTemplateValue);
        /// <summary> VirtualNetwork. </summary>
        public static VCenterInventoryType VirtualNetwork { get; } = new VCenterInventoryType(VirtualNetworkValue);
        /// <summary> Cluster. </summary>
        public static VCenterInventoryType Cluster { get; } = new VCenterInventoryType(ClusterValue);
        /// <summary> Datastore. </summary>
        public static VCenterInventoryType Datastore { get; } = new VCenterInventoryType(DatastoreValue);
        /// <summary> Host. </summary>
        public static VCenterInventoryType Host { get; } = new VCenterInventoryType(HostValue);
        /// <summary> Determines if two <see cref="VCenterInventoryType"/> values are the same. </summary>
        public static bool operator ==(VCenterInventoryType left, VCenterInventoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VCenterInventoryType"/> values are not the same. </summary>
        public static bool operator !=(VCenterInventoryType left, VCenterInventoryType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VCenterInventoryType"/>. </summary>
        public static implicit operator VCenterInventoryType(string value) => new VCenterInventoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VCenterInventoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VCenterInventoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
