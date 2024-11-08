// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum for all classification models supported by AutoML. </summary>
    public readonly partial struct BlockedTransformer : IEquatable<BlockedTransformer>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlockedTransformer"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlockedTransformer(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextTargetEncoderValue = "TextTargetEncoder";
        private const string OneHotEncoderValue = "OneHotEncoder";
        private const string CatTargetEncoderValue = "CatTargetEncoder";
        private const string TfIdfValue = "TfIdf";
        private const string WoETargetEncoderValue = "WoETargetEncoder";
        private const string LabelEncoderValue = "LabelEncoder";
        private const string WordEmbeddingValue = "WordEmbedding";
        private const string NaiveBayesValue = "NaiveBayes";
        private const string CountVectorizerValue = "CountVectorizer";
        private const string HashOneHotEncoderValue = "HashOneHotEncoder";

        /// <summary> Target encoding for text data. </summary>
        public static BlockedTransformer TextTargetEncoder { get; } = new BlockedTransformer(TextTargetEncoderValue);
        /// <summary> Ohe hot encoding creates a binary feature transformation. </summary>
        public static BlockedTransformer OneHotEncoder { get; } = new BlockedTransformer(OneHotEncoderValue);
        /// <summary> Target encoding for categorical data. </summary>
        public static BlockedTransformer CatTargetEncoder { get; } = new BlockedTransformer(CatTargetEncoderValue);
        /// <summary> Tf-Idf stands for, term-frequency times inverse document-frequency. This is a common term weighting scheme for identifying information from documents. </summary>
        public static BlockedTransformer TfIdf { get; } = new BlockedTransformer(TfIdfValue);
        /// <summary> Weight of Evidence encoding is a technique used to encode categorical variables. It uses the natural log of the P(1)/P(0) to create weights. </summary>
        public static BlockedTransformer WoETargetEncoder { get; } = new BlockedTransformer(WoETargetEncoderValue);
        /// <summary> Label encoder converts labels/categorical variables in a numerical form. </summary>
        public static BlockedTransformer LabelEncoder { get; } = new BlockedTransformer(LabelEncoderValue);
        /// <summary> Word embedding helps represents words or phrases as a vector, or a series of numbers. </summary>
        public static BlockedTransformer WordEmbedding { get; } = new BlockedTransformer(WordEmbeddingValue);
        /// <summary> Naive Bayes is a classified that is used for classification of discrete features that are categorically distributed. </summary>
        public static BlockedTransformer NaiveBayes { get; } = new BlockedTransformer(NaiveBayesValue);
        /// <summary> Count Vectorizer converts a collection of text documents to a matrix of token counts. </summary>
        public static BlockedTransformer CountVectorizer { get; } = new BlockedTransformer(CountVectorizerValue);
        /// <summary> Hashing One Hot Encoder can turn categorical variables into a limited number of new features. This is often used for high-cardinality categorical features. </summary>
        public static BlockedTransformer HashOneHotEncoder { get; } = new BlockedTransformer(HashOneHotEncoderValue);
        /// <summary> Determines if two <see cref="BlockedTransformer"/> values are the same. </summary>
        public static bool operator ==(BlockedTransformer left, BlockedTransformer right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlockedTransformer"/> values are not the same. </summary>
        public static bool operator !=(BlockedTransformer left, BlockedTransformer right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlockedTransformer"/>. </summary>
        public static implicit operator BlockedTransformer(string value) => new BlockedTransformer(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlockedTransformer other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlockedTransformer other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
