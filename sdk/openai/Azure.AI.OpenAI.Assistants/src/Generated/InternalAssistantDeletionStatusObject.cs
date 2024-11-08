// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The InternalAssistantDeletionStatus_object. </summary>
    internal readonly partial struct InternalAssistantDeletionStatusObject : IEquatable<InternalAssistantDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalAssistantDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalAssistantDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssistantDeletedValue = "assistant.deleted";

        /// <summary> assistant.deleted. </summary>
        public static InternalAssistantDeletionStatusObject AssistantDeleted { get; } = new InternalAssistantDeletionStatusObject(AssistantDeletedValue);
        /// <summary> Determines if two <see cref="InternalAssistantDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(InternalAssistantDeletionStatusObject left, InternalAssistantDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalAssistantDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(InternalAssistantDeletionStatusObject left, InternalAssistantDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InternalAssistantDeletionStatusObject"/>. </summary>
        public static implicit operator InternalAssistantDeletionStatusObject(string value) => new InternalAssistantDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAssistantDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalAssistantDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
