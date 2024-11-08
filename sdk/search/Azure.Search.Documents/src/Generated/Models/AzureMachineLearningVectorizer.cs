// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Specifies an Azure Machine Learning endpoint deployed via the Azure AI Studio Model Catalog for generating the vector embedding of a query string. </summary>
    public partial class AzureMachineLearningVectorizer : VectorSearchVectorizer
    {
        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningVectorizer"/>. </summary>
        /// <param name="vectorizerName"> The name to associate with this particular vectorization method. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vectorizerName"/> is null. </exception>
        public AzureMachineLearningVectorizer(string vectorizerName) : base(vectorizerName)
        {
            Argument.AssertNotNull(vectorizerName, nameof(vectorizerName));

            Kind = VectorSearchVectorizerKind.AML;
        }

        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningVectorizer"/>. </summary>
        /// <param name="vectorizerName"> The name to associate with this particular vectorization method. </param>
        /// <param name="kind"> The name of the kind of vectorization method being configured for use with vector search. </param>
        /// <param name="amlParameters"> Specifies the properties of the AML vectorizer. </param>
        internal AzureMachineLearningVectorizer(string vectorizerName, VectorSearchVectorizerKind kind, AzureMachineLearningParameters amlParameters) : base(vectorizerName, kind)
        {
            AMLParameters = amlParameters;
            Kind = kind;
        }

        /// <summary> Specifies the properties of the AML vectorizer. </summary>
        public AzureMachineLearningParameters AMLParameters { get; set; }
    }
}
