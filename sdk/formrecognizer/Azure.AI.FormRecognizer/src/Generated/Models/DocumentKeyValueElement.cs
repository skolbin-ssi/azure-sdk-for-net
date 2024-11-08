// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing the field key or value in a key-value pair. </summary>
    public partial class DocumentKeyValueElement
    {
        /// <summary> Initializes a new instance of <see cref="DocumentKeyValueElement"/>. </summary>
        /// <param name="content"> Concatenated content of the key-value element in reading order. </param>
        /// <param name="spans"> Location of the key-value element in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentKeyValueElement(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentKeyValueElement"/>. </summary>
        /// <param name="content"> Concatenated content of the key-value element in reading order. </param>
        /// <param name="boundingRegions"> Bounding regions covering the key-value element. </param>
        /// <param name="spans"> Location of the key-value element in the reading order concatenated content. </param>
        internal DocumentKeyValueElement(string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans)
        {
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Concatenated content of the key-value element in reading order. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the key-value element. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the key-value element in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
