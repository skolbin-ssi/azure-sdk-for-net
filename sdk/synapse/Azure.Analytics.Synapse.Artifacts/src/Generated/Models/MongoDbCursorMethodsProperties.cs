// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Cursor methods for Mongodb query. </summary>
    public partial class MongoDbCursorMethodsProperties
    {
        /// <summary> Initializes a new instance of <see cref="MongoDbCursorMethodsProperties"/>. </summary>
        public MongoDbCursorMethodsProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDbCursorMethodsProperties"/>. </summary>
        /// <param name="project"> Specifies the fields to return in the documents that match the query filter. To return all fields in the matching documents, omit this parameter. Type: string (or Expression with resultType string). </param>
        /// <param name="sort"> Specifies the order in which the query returns matching documents. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string). </param>
        /// <param name="skip"> Specifies the how many documents skipped and where MongoDB begins returning results. This approach may be useful in implementing paginated results. Type: integer (or Expression with resultType integer). </param>
        /// <param name="limit"> Specifies the maximum number of documents the server returns. limit() is analogous to the LIMIT statement in a SQL database. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal MongoDbCursorMethodsProperties(object project, object sort, object skip, object limit, IDictionary<string, object> additionalProperties)
        {
            Project = project;
            Sort = sort;
            Skip = skip;
            Limit = limit;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Specifies the fields to return in the documents that match the query filter. To return all fields in the matching documents, omit this parameter. Type: string (or Expression with resultType string). </summary>
        public object Project { get; set; }
        /// <summary> Specifies the order in which the query returns matching documents. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string). </summary>
        public object Sort { get; set; }
        /// <summary> Specifies the how many documents skipped and where MongoDB begins returning results. This approach may be useful in implementing paginated results. Type: integer (or Expression with resultType integer). </summary>
        public object Skip { get; set; }
        /// <summary> Specifies the maximum number of documents the server returns. limit() is analogous to the LIMIT statement in a SQL database. Type: integer (or Expression with resultType integer). </summary>
        public object Limit { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
