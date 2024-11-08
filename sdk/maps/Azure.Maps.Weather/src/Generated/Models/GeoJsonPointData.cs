// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    /// <summary> Data contained by a `GeoJson Point`. </summary>
    internal partial class GeoJsonPointData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonPointData"/>. </summary>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        internal GeoJsonPointData(IEnumerable<double> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPointData"/>. </summary>
        /// <param name="coordinates"> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </param>
        internal GeoJsonPointData(IReadOnlyList<double> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> A `Position` is an array of numbers with two or more elements. The first two elements are _longitude_ and _latitude_, precisely in that order. _Altitude/Elevation_ is an optional third element. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.1) for details. </summary>
        public IReadOnlyList<double> Coordinates { get; }
    }
}
