// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Protocol of gateway load balancer tunnel interface. </summary>
    public readonly partial struct GatewayLoadBalancerTunnelProtocol : IEquatable<GatewayLoadBalancerTunnelProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GatewayLoadBalancerTunnelProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GatewayLoadBalancerTunnelProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string NativeValue = "Native";
        private const string VxlanValue = "VXLAN";

        /// <summary> None. </summary>
        public static GatewayLoadBalancerTunnelProtocol None { get; } = new GatewayLoadBalancerTunnelProtocol(NoneValue);
        /// <summary> Native. </summary>
        public static GatewayLoadBalancerTunnelProtocol Native { get; } = new GatewayLoadBalancerTunnelProtocol(NativeValue);
        /// <summary> VXLAN. </summary>
        public static GatewayLoadBalancerTunnelProtocol Vxlan { get; } = new GatewayLoadBalancerTunnelProtocol(VxlanValue);
        /// <summary> Determines if two <see cref="GatewayLoadBalancerTunnelProtocol"/> values are the same. </summary>
        public static bool operator ==(GatewayLoadBalancerTunnelProtocol left, GatewayLoadBalancerTunnelProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GatewayLoadBalancerTunnelProtocol"/> values are not the same. </summary>
        public static bool operator !=(GatewayLoadBalancerTunnelProtocol left, GatewayLoadBalancerTunnelProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GatewayLoadBalancerTunnelProtocol"/>. </summary>
        public static implicit operator GatewayLoadBalancerTunnelProtocol(string value) => new GatewayLoadBalancerTunnelProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GatewayLoadBalancerTunnelProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GatewayLoadBalancerTunnelProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
