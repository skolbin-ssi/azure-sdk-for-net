// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> A list of PEM formatted certificates. </summary>
    public partial class PemCertificateList : CertificateSource
    {
        /// <summary> Initializes a new instance of <see cref="PemCertificateList"/>. </summary>
        /// <param name="certificates"> PEM formatted public certificates. One certificate per entry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificates"/> is null. </exception>
        public PemCertificateList(IEnumerable<string> certificates)
        {
            Argument.AssertNotNull(certificates, nameof(certificates));

            Certificates = certificates.ToList();
            Type = "#Microsoft.VideoAnalyzer.PemCertificateList";
        }

        /// <summary> Initializes a new instance of <see cref="PemCertificateList"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="certificates"> PEM formatted public certificates. One certificate per entry. </param>
        internal PemCertificateList(string type, IList<string> certificates) : base(type)
        {
            Certificates = certificates;
            Type = type ?? "#Microsoft.VideoAnalyzer.PemCertificateList";
        }

        /// <summary> PEM formatted public certificates. One certificate per entry. </summary>
        public IList<string> Certificates { get; }
    }
}
