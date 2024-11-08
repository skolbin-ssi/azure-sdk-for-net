// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Payload for iSCSI Target create or update requests. </summary>
    public partial class DiskPoolIscsiTargetCreateOrUpdateContent : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetCreateOrUpdateContent"/>. </summary>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        public DiskPoolIscsiTargetCreateOrUpdateContent(DiskPoolIscsiTargetAclMode aclMode)
        {
            ManagedByExtended = new ChangeTrackingList<string>();
            AclMode = aclMode;
            StaticAcls = new ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>();
            Luns = new ChangeTrackingList<ManagedDiskIscsiLun>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolIscsiTargetCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedBy, IList<string> managedByExtended, DiskPoolIscsiTargetAclMode aclMode, string targetIqn, IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls, IList<ManagedDiskIscsiLun> luns, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            AclMode = aclMode;
            TargetIqn = targetIqn;
            StaticAcls = staticAcls;
            Luns = luns;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolIscsiTargetCreateOrUpdateContent"/> for deserialization. </summary>
        internal DiskPoolIscsiTargetCreateOrUpdateContent()
        {
        }

        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Mode for Target connectivity. </summary>
        public DiskPoolIscsiTargetAclMode AclMode { get; set; }
        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </summary>
        public string TargetIqn { get; set; }
        /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
        public IList<DiskPoolIscsiTargetPortalGroupAcl> StaticAcls { get; }
        /// <summary> List of LUNs to be exposed through iSCSI Target. </summary>
        public IList<ManagedDiskIscsiLun> Luns { get; }
    }
}
