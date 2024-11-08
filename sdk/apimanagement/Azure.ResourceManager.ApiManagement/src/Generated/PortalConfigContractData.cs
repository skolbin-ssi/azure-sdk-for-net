// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the PortalConfigContract data model.
    /// The developer portal configuration contract.
    /// </summary>
    public partial class PortalConfigContractData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PortalConfigContractData"/>. </summary>
        public PortalConfigContractData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PortalConfigContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="enableBasicAuth"> Enable or disable Basic authentication method. </param>
        /// <param name="signin"></param>
        /// <param name="signup"></param>
        /// <param name="delegation"> The developer portal delegation settings. </param>
        /// <param name="cors"> The developer portal Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="csp"> The developer portal Content Security Policy (CSP) settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PortalConfigContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? enableBasicAuth, PortalConfigPropertiesSignin signin, PortalConfigPropertiesSignup signup, PortalConfigDelegationProperties delegation, PortalConfigCorsProperties cors, PortalConfigCspProperties csp, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            EnableBasicAuth = enableBasicAuth;
            Signin = signin;
            Signup = signup;
            Delegation = delegation;
            Cors = cors;
            Csp = csp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable or disable Basic authentication method. </summary>
        [WirePath("properties.enableBasicAuth")]
        public bool? EnableBasicAuth { get; set; }
        /// <summary> Gets or sets the signin. </summary>
        internal PortalConfigPropertiesSignin Signin { get; set; }
        /// <summary> Redirect anonymous users to the sign-in page. </summary>
        [WirePath("properties.signin.require")]
        public bool? Require
        {
            get => Signin is null ? default : Signin.Require;
            set
            {
                if (Signin is null)
                    Signin = new PortalConfigPropertiesSignin();
                Signin.Require = value;
            }
        }

        /// <summary> Gets or sets the signup. </summary>
        internal PortalConfigPropertiesSignup Signup { get; set; }
        /// <summary> Terms of service settings. </summary>
        [WirePath("properties.signup.termsOfService")]
        public PortalConfigTermsOfServiceProperties SignupTermsOfService
        {
            get => Signup is null ? default : Signup.TermsOfService;
            set
            {
                if (Signup is null)
                    Signup = new PortalConfigPropertiesSignup();
                Signup.TermsOfService = value;
            }
        }

        /// <summary> The developer portal delegation settings. </summary>
        [WirePath("properties.delegation")]
        public PortalConfigDelegationProperties Delegation { get; set; }
        /// <summary> The developer portal Cross-Origin Resource Sharing (CORS) settings. </summary>
        internal PortalConfigCorsProperties Cors { get; set; }
        /// <summary> Allowed origins, e.g. `https://trusted.com`. </summary>
        [WirePath("properties.cors.allowedOrigins")]
        public IList<string> CorsAllowedOrigins
        {
            get
            {
                if (Cors is null)
                    Cors = new PortalConfigCorsProperties();
                return Cors.AllowedOrigins;
            }
        }

        /// <summary> The developer portal Content Security Policy (CSP) settings. </summary>
        [WirePath("properties.csp")]
        public PortalConfigCspProperties Csp { get; set; }
    }
}
