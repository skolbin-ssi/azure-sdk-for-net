// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 agreement envelope settings. </summary>
    public partial class X12EnvelopeSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeSettings"/>. </summary>
        /// <param name="controlStandardsId"> The controls standards id. </param>
        /// <param name="useControlStandardsIdAsRepetitionCharacter"> The value indicating whether to use control standards id as repetition character. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="receiverApplicationId"> The receiver application id. </param>
        /// <param name="controlVersionNumber"> The control version number. </param>
        /// <param name="interchangeControlNumberLowerBound"> The interchange  control number lower bound. </param>
        /// <param name="interchangeControlNumberUpperBound"> The interchange  control number upper bound. </param>
        /// <param name="rolloverInterchangeControlNumber"> The value indicating whether to rollover interchange control number. </param>
        /// <param name="enableDefaultGroupHeaders"> The value indicating whether to enable default group headers. </param>
        /// <param name="groupControlNumberLowerBound"> The group control number lower bound. </param>
        /// <param name="groupControlNumberUpperBound"> The group control number upper bound. </param>
        /// <param name="rolloverGroupControlNumber"> The value indicating whether to rollover group control number. </param>
        /// <param name="groupHeaderAgencyCode"> The group header agency code. </param>
        /// <param name="groupHeaderVersion"> The group header version. </param>
        /// <param name="transactionSetControlNumberLowerBound"> The transaction set control number lower bound. </param>
        /// <param name="transactionSetControlNumberUpperBound"> The transaction set control number upper bound. </param>
        /// <param name="rolloverTransactionSetControlNumber"> The value indicating whether to rollover transaction set control number. </param>
        /// <param name="overwriteExistingTransactionSetControlNumber"> The value indicating whether to overwrite existing transaction set control number. </param>
        /// <param name="groupHeaderDateFormat"> The group header date format. </param>
        /// <param name="groupHeaderTimeFormat"> The group header time format. </param>
        /// <param name="usageIndicator"> The usage indicator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderApplicationId"/>, <paramref name="receiverApplicationId"/>, <paramref name="controlVersionNumber"/>, <paramref name="groupHeaderAgencyCode"/> or <paramref name="groupHeaderVersion"/> is null. </exception>
        public X12EnvelopeSettings(int controlStandardsId, bool useControlStandardsIdAsRepetitionCharacter, string senderApplicationId, string receiverApplicationId, string controlVersionNumber, int interchangeControlNumberLowerBound, int interchangeControlNumberUpperBound, bool rolloverInterchangeControlNumber, bool enableDefaultGroupHeaders, int groupControlNumberLowerBound, int groupControlNumberUpperBound, bool rolloverGroupControlNumber, string groupHeaderAgencyCode, string groupHeaderVersion, int transactionSetControlNumberLowerBound, int transactionSetControlNumberUpperBound, bool rolloverTransactionSetControlNumber, bool overwriteExistingTransactionSetControlNumber, X12DateFormat groupHeaderDateFormat, X12TimeFormat groupHeaderTimeFormat, UsageIndicator usageIndicator)
        {
            Argument.AssertNotNull(senderApplicationId, nameof(senderApplicationId));
            Argument.AssertNotNull(receiverApplicationId, nameof(receiverApplicationId));
            Argument.AssertNotNull(controlVersionNumber, nameof(controlVersionNumber));
            Argument.AssertNotNull(groupHeaderAgencyCode, nameof(groupHeaderAgencyCode));
            Argument.AssertNotNull(groupHeaderVersion, nameof(groupHeaderVersion));

            ControlStandardsId = controlStandardsId;
            UseControlStandardsIdAsRepetitionCharacter = useControlStandardsIdAsRepetitionCharacter;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationId = receiverApplicationId;
            ControlVersionNumber = controlVersionNumber;
            InterchangeControlNumberLowerBound = interchangeControlNumberLowerBound;
            InterchangeControlNumberUpperBound = interchangeControlNumberUpperBound;
            RolloverInterchangeControlNumber = rolloverInterchangeControlNumber;
            EnableDefaultGroupHeaders = enableDefaultGroupHeaders;
            GroupControlNumberLowerBound = groupControlNumberLowerBound;
            GroupControlNumberUpperBound = groupControlNumberUpperBound;
            RolloverGroupControlNumber = rolloverGroupControlNumber;
            GroupHeaderAgencyCode = groupHeaderAgencyCode;
            GroupHeaderVersion = groupHeaderVersion;
            TransactionSetControlNumberLowerBound = transactionSetControlNumberLowerBound;
            TransactionSetControlNumberUpperBound = transactionSetControlNumberUpperBound;
            RolloverTransactionSetControlNumber = rolloverTransactionSetControlNumber;
            OverwriteExistingTransactionSetControlNumber = overwriteExistingTransactionSetControlNumber;
            GroupHeaderDateFormat = groupHeaderDateFormat;
            GroupHeaderTimeFormat = groupHeaderTimeFormat;
            UsageIndicator = usageIndicator;
        }

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeSettings"/>. </summary>
        /// <param name="controlStandardsId"> The controls standards id. </param>
        /// <param name="useControlStandardsIdAsRepetitionCharacter"> The value indicating whether to use control standards id as repetition character. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="receiverApplicationId"> The receiver application id. </param>
        /// <param name="controlVersionNumber"> The control version number. </param>
        /// <param name="interchangeControlNumberLowerBound"> The interchange  control number lower bound. </param>
        /// <param name="interchangeControlNumberUpperBound"> The interchange  control number upper bound. </param>
        /// <param name="rolloverInterchangeControlNumber"> The value indicating whether to rollover interchange control number. </param>
        /// <param name="enableDefaultGroupHeaders"> The value indicating whether to enable default group headers. </param>
        /// <param name="functionalGroupId"> The functional group id. </param>
        /// <param name="groupControlNumberLowerBound"> The group control number lower bound. </param>
        /// <param name="groupControlNumberUpperBound"> The group control number upper bound. </param>
        /// <param name="rolloverGroupControlNumber"> The value indicating whether to rollover group control number. </param>
        /// <param name="groupHeaderAgencyCode"> The group header agency code. </param>
        /// <param name="groupHeaderVersion"> The group header version. </param>
        /// <param name="transactionSetControlNumberLowerBound"> The transaction set control number lower bound. </param>
        /// <param name="transactionSetControlNumberUpperBound"> The transaction set control number upper bound. </param>
        /// <param name="rolloverTransactionSetControlNumber"> The value indicating whether to rollover transaction set control number. </param>
        /// <param name="transactionSetControlNumberPrefix"> The transaction set control number prefix. </param>
        /// <param name="transactionSetControlNumberSuffix"> The transaction set control number suffix. </param>
        /// <param name="overwriteExistingTransactionSetControlNumber"> The value indicating whether to overwrite existing transaction set control number. </param>
        /// <param name="groupHeaderDateFormat"> The group header date format. </param>
        /// <param name="groupHeaderTimeFormat"> The group header time format. </param>
        /// <param name="usageIndicator"> The usage indicator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal X12EnvelopeSettings(int controlStandardsId, bool useControlStandardsIdAsRepetitionCharacter, string senderApplicationId, string receiverApplicationId, string controlVersionNumber, int interchangeControlNumberLowerBound, int interchangeControlNumberUpperBound, bool rolloverInterchangeControlNumber, bool enableDefaultGroupHeaders, string functionalGroupId, int groupControlNumberLowerBound, int groupControlNumberUpperBound, bool rolloverGroupControlNumber, string groupHeaderAgencyCode, string groupHeaderVersion, int transactionSetControlNumberLowerBound, int transactionSetControlNumberUpperBound, bool rolloverTransactionSetControlNumber, string transactionSetControlNumberPrefix, string transactionSetControlNumberSuffix, bool overwriteExistingTransactionSetControlNumber, X12DateFormat groupHeaderDateFormat, X12TimeFormat groupHeaderTimeFormat, UsageIndicator usageIndicator, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ControlStandardsId = controlStandardsId;
            UseControlStandardsIdAsRepetitionCharacter = useControlStandardsIdAsRepetitionCharacter;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationId = receiverApplicationId;
            ControlVersionNumber = controlVersionNumber;
            InterchangeControlNumberLowerBound = interchangeControlNumberLowerBound;
            InterchangeControlNumberUpperBound = interchangeControlNumberUpperBound;
            RolloverInterchangeControlNumber = rolloverInterchangeControlNumber;
            EnableDefaultGroupHeaders = enableDefaultGroupHeaders;
            FunctionalGroupId = functionalGroupId;
            GroupControlNumberLowerBound = groupControlNumberLowerBound;
            GroupControlNumberUpperBound = groupControlNumberUpperBound;
            RolloverGroupControlNumber = rolloverGroupControlNumber;
            GroupHeaderAgencyCode = groupHeaderAgencyCode;
            GroupHeaderVersion = groupHeaderVersion;
            TransactionSetControlNumberLowerBound = transactionSetControlNumberLowerBound;
            TransactionSetControlNumberUpperBound = transactionSetControlNumberUpperBound;
            RolloverTransactionSetControlNumber = rolloverTransactionSetControlNumber;
            TransactionSetControlNumberPrefix = transactionSetControlNumberPrefix;
            TransactionSetControlNumberSuffix = transactionSetControlNumberSuffix;
            OverwriteExistingTransactionSetControlNumber = overwriteExistingTransactionSetControlNumber;
            GroupHeaderDateFormat = groupHeaderDateFormat;
            GroupHeaderTimeFormat = groupHeaderTimeFormat;
            UsageIndicator = usageIndicator;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeSettings"/> for deserialization. </summary>
        internal X12EnvelopeSettings()
        {
        }

        /// <summary> The controls standards id. </summary>
        public int ControlStandardsId { get; set; }
        /// <summary> The value indicating whether to use control standards id as repetition character. </summary>
        public bool UseControlStandardsIdAsRepetitionCharacter { get; set; }
        /// <summary> The sender application id. </summary>
        public string SenderApplicationId { get; set; }
        /// <summary> The receiver application id. </summary>
        public string ReceiverApplicationId { get; set; }
        /// <summary> The control version number. </summary>
        public string ControlVersionNumber { get; set; }
        /// <summary> The interchange  control number lower bound. </summary>
        public int InterchangeControlNumberLowerBound { get; set; }
        /// <summary> The interchange  control number upper bound. </summary>
        public int InterchangeControlNumberUpperBound { get; set; }
        /// <summary> The value indicating whether to rollover interchange control number. </summary>
        public bool RolloverInterchangeControlNumber { get; set; }
        /// <summary> The value indicating whether to enable default group headers. </summary>
        public bool EnableDefaultGroupHeaders { get; set; }
        /// <summary> The functional group id. </summary>
        public string FunctionalGroupId { get; set; }
        /// <summary> The group control number lower bound. </summary>
        public int GroupControlNumberLowerBound { get; set; }
        /// <summary> The group control number upper bound. </summary>
        public int GroupControlNumberUpperBound { get; set; }
        /// <summary> The value indicating whether to rollover group control number. </summary>
        public bool RolloverGroupControlNumber { get; set; }
        /// <summary> The group header agency code. </summary>
        public string GroupHeaderAgencyCode { get; set; }
        /// <summary> The group header version. </summary>
        public string GroupHeaderVersion { get; set; }
        /// <summary> The transaction set control number lower bound. </summary>
        public int TransactionSetControlNumberLowerBound { get; set; }
        /// <summary> The transaction set control number upper bound. </summary>
        public int TransactionSetControlNumberUpperBound { get; set; }
        /// <summary> The value indicating whether to rollover transaction set control number. </summary>
        public bool RolloverTransactionSetControlNumber { get; set; }
        /// <summary> The transaction set control number prefix. </summary>
        public string TransactionSetControlNumberPrefix { get; set; }
        /// <summary> The transaction set control number suffix. </summary>
        public string TransactionSetControlNumberSuffix { get; set; }
        /// <summary> The value indicating whether to overwrite existing transaction set control number. </summary>
        public bool OverwriteExistingTransactionSetControlNumber { get; set; }
        /// <summary> The group header date format. </summary>
        public X12DateFormat GroupHeaderDateFormat { get; set; }
        /// <summary> The group header time format. </summary>
        public X12TimeFormat GroupHeaderTimeFormat { get; set; }
        /// <summary> The usage indicator. </summary>
        public UsageIndicator UsageIndicator { get; set; }
    }
}
