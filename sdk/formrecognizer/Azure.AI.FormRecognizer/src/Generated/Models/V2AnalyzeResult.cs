// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Analyze operation result. </summary>
    internal partial class V2AnalyzeResult
    {
        /// <summary> Initializes a new instance of <see cref="V2AnalyzeResult"/>. </summary>
        /// <param name="version"> Version of schema used for this result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        internal V2AnalyzeResult(string version)
        {
            Argument.AssertNotNull(version, nameof(version));

            Version = version;
            ReadResults = new ChangeTrackingList<ReadResult>();
            PageResults = new ChangeTrackingList<PageResult>();
            DocumentResults = new ChangeTrackingList<DocumentResult>();
            Errors = new ChangeTrackingList<FormRecognizerError>();
        }

        /// <summary> Initializes a new instance of <see cref="V2AnalyzeResult"/>. </summary>
        /// <param name="version"> Version of schema used for this result. </param>
        /// <param name="readResults"> Text extracted from the input. </param>
        /// <param name="pageResults"> Page-level information extracted from the input. </param>
        /// <param name="documentResults"> Document-level information extracted from the input. </param>
        /// <param name="errors"> List of errors reported during the analyze operation. </param>
        internal V2AnalyzeResult(string version, IReadOnlyList<ReadResult> readResults, IReadOnlyList<PageResult> pageResults, IReadOnlyList<DocumentResult> documentResults, IReadOnlyList<FormRecognizerError> errors)
        {
            Version = version;
            ReadResults = readResults;
            PageResults = pageResults;
            DocumentResults = documentResults;
            Errors = errors;
        }

        /// <summary> Version of schema used for this result. </summary>
        public string Version { get; }
        /// <summary> Text extracted from the input. </summary>
        public IReadOnlyList<ReadResult> ReadResults { get; }
        /// <summary> Page-level information extracted from the input. </summary>
        public IReadOnlyList<PageResult> PageResults { get; }
        /// <summary> Document-level information extracted from the input. </summary>
        public IReadOnlyList<DocumentResult> DocumentResults { get; }
        /// <summary> List of errors reported during the analyze operation. </summary>
        public IReadOnlyList<FormRecognizerError> Errors { get; }
    }
}
