// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single item in a List or Get VirtualNetworkRules operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkRule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        public VirtualNetworkRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="virtualNetworkSubnetId">ARM ID of Virtual Network
        /// Subnet</param>
        public VirtualNetworkRule(string id = default(string), string name = default(string), string type = default(string), string virtualNetworkSubnetId = default(string))
            : base(id, name, type)
        {
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM ID of Virtual Network Subnet
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkSubnetId")]
        public string VirtualNetworkSubnetId { get; set; }

    }
}
