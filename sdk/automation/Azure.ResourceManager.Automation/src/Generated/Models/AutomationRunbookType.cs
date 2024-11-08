// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets or sets the type of the runbook. </summary>
    public readonly partial struct AutomationRunbookType : IEquatable<AutomationRunbookType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRunbookType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScriptValue = "Script";
        private const string GraphValue = "Graph";
        private const string PowerShellWorkflowValue = "PowerShellWorkflow";
        private const string PowerShellValue = "PowerShell";
        private const string GraphPowerShellWorkflowValue = "GraphPowerShellWorkflow";
        private const string GraphPowerShellValue = "GraphPowerShell";
        private const string Python2Value = "Python2";
        private const string Python3Value = "Python3";

        /// <summary> Script. </summary>
        public static AutomationRunbookType Script { get; } = new AutomationRunbookType(ScriptValue);
        /// <summary> Graph. </summary>
        public static AutomationRunbookType Graph { get; } = new AutomationRunbookType(GraphValue);
        /// <summary> PowerShellWorkflow. </summary>
        public static AutomationRunbookType PowerShellWorkflow { get; } = new AutomationRunbookType(PowerShellWorkflowValue);
        /// <summary> PowerShell. </summary>
        public static AutomationRunbookType PowerShell { get; } = new AutomationRunbookType(PowerShellValue);
        /// <summary> GraphPowerShellWorkflow. </summary>
        public static AutomationRunbookType GraphPowerShellWorkflow { get; } = new AutomationRunbookType(GraphPowerShellWorkflowValue);
        /// <summary> GraphPowerShell. </summary>
        public static AutomationRunbookType GraphPowerShell { get; } = new AutomationRunbookType(GraphPowerShellValue);
        /// <summary> Python2. </summary>
        public static AutomationRunbookType Python2 { get; } = new AutomationRunbookType(Python2Value);
        /// <summary> Python3. </summary>
        public static AutomationRunbookType Python3 { get; } = new AutomationRunbookType(Python3Value);
        /// <summary> Determines if two <see cref="AutomationRunbookType"/> values are the same. </summary>
        public static bool operator ==(AutomationRunbookType left, AutomationRunbookType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRunbookType"/> values are not the same. </summary>
        public static bool operator !=(AutomationRunbookType left, AutomationRunbookType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutomationRunbookType"/>. </summary>
        public static implicit operator AutomationRunbookType(string value) => new AutomationRunbookType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRunbookType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRunbookType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
