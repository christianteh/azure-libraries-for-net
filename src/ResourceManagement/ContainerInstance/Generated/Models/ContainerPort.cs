// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The port exposed on the container instance.
    /// </summary>
    public partial class ContainerPort
    {
        /// <summary>
        /// Initializes a new instance of the ContainerPort class.
        /// </summary>
        public ContainerPort()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerPort class.
        /// </summary>
        /// <param name="port">The port number exposed within the container
        /// group.</param>
        /// <param name="protocol">The protocol associated with the port.
        /// Possible values include: 'TCP', 'UDP'</param>
        public ContainerPort(int port, string protocol = default(string))
        {
            Protocol = protocol;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the protocol associated with the port. Possible values
        /// include: 'TCP', 'UDP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the port number exposed within the container group.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
