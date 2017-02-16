// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for the issuer of the X509 component of a certificate.
    /// </summary>
    public partial class IssuerParameters
    {
        /// <summary>
        /// Initializes a new instance of the IssuerParameters class.
        /// </summary>
        public IssuerParameters() { }

        /// <summary>
        /// Initializes a new instance of the IssuerParameters class.
        /// </summary>
        /// <param name="name">Name of the referenced issuer object or
        /// reserved names e.g. 'Self', 'Unknown'.</param>
        /// <param name="certificateType">Type of certificate to be requested
        /// from the issuer provider.</param>
        public IssuerParameters(string name = default(string), string certificateType = default(string))
        {
            Name = name;
            CertificateType = certificateType;
        }

        /// <summary>
        /// Gets or sets name of the referenced issuer object or reserved
        /// names e.g. 'Self', 'Unknown'.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of certificate to be requested from the issuer
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "cty")]
        public string CertificateType { get; set; }

    }
}