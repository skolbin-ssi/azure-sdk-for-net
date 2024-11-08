// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> The SemanticDebugInfo. </summary>
    public partial class SemanticDebugInfo
    {
        /// <summary> Initializes a new instance of <see cref="SemanticDebugInfo"/>. </summary>
        internal SemanticDebugInfo()
        {
            ContentFields = new ChangeTrackingList<QueryResultDocumentSemanticField>();
            KeywordFields = new ChangeTrackingList<QueryResultDocumentSemanticField>();
        }

        /// <summary> Initializes a new instance of <see cref="SemanticDebugInfo"/>. </summary>
        /// <param name="titleField"> The title field that was sent to the semantic enrichment process, as well as how it was used. </param>
        /// <param name="contentFields"> The content fields that were sent to the semantic enrichment process, as well as how they were used. </param>
        /// <param name="keywordFields"> The keyword fields that were sent to the semantic enrichment process, as well as how they were used. </param>
        /// <param name="rerankerInput"> The raw concatenated strings that were sent to the semantic enrichment process. </param>
        internal SemanticDebugInfo(QueryResultDocumentSemanticField titleField, IReadOnlyList<QueryResultDocumentSemanticField> contentFields, IReadOnlyList<QueryResultDocumentSemanticField> keywordFields, QueryResultDocumentRerankerInput rerankerInput)
        {
            TitleField = titleField;
            ContentFields = contentFields;
            KeywordFields = keywordFields;
            RerankerInput = rerankerInput;
        }

        /// <summary> The title field that was sent to the semantic enrichment process, as well as how it was used. </summary>
        public QueryResultDocumentSemanticField TitleField { get; }
        /// <summary> The content fields that were sent to the semantic enrichment process, as well as how they were used. </summary>
        public IReadOnlyList<QueryResultDocumentSemanticField> ContentFields { get; }
        /// <summary> The keyword fields that were sent to the semantic enrichment process, as well as how they were used. </summary>
        public IReadOnlyList<QueryResultDocumentSemanticField> KeywordFields { get; }
        /// <summary> The raw concatenated strings that were sent to the semantic enrichment process. </summary>
        public QueryResultDocumentRerankerInput RerankerInput { get; }
    }
}
