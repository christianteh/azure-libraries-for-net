// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource validation request content.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ValidateRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the ValidateRequestInner class.
        /// </summary>
        public ValidateRequestInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateRequestInner class.
        /// </summary>
        /// <param name="name">Resource name to verify.</param>
        /// <param name="type">Resource type used for verification. Possible
        /// values include: 'ServerFarm', 'Site'</param>
        /// <param name="location">Expected location of the resource.</param>
        /// <param name="serverFarmId">ARM resource ID of an App Service plan
        /// that would host the app.</param>
        /// <param name="skuName">Name of the target SKU for the App Service
        /// plan.</param>
        /// <param name="needLinuxWorkers">&lt;code&gt;true&lt;/code&gt; if App
        /// Service plan is for Linux workers; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="isSpot">&lt;code&gt;true&lt;/code&gt; if App Service
        /// plan is for Spot instances; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="capacity">Target capacity of the App Service plan
        /// (number of VM's).</param>
        /// <param name="hostingEnvironment">Name of App Service Environment
        /// where app or App Service plan should be created.</param>
        public ValidateRequestInner(string name, string type, string location, string serverFarmId = default(string), string skuName = default(string), bool? needLinuxWorkers = default(bool?), bool? isSpot = default(bool?), int? capacity = default(int?), string hostingEnvironment = default(string))
        {
            Name = name;
            Type = type;
            Location = location;
            ServerFarmId = serverFarmId;
            SkuName = skuName;
            NeedLinuxWorkers = needLinuxWorkers;
            IsSpot = isSpot;
            Capacity = capacity;
            HostingEnvironment = hostingEnvironment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource name to verify.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type used for verification. Possible values
        /// include: 'ServerFarm', 'Site'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets expected location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets ARM resource ID of an App Service plan that would host
        /// the app.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverFarmId")]
        public string ServerFarmId { get; set; }

        /// <summary>
        /// Gets or sets name of the target SKU for the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if App
        /// Service plan is for Linux workers; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.needLinuxWorkers")]
        public bool? NeedLinuxWorkers { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if App
        /// Service plan is for Spot instances; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isSpot")]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// Gets or sets target capacity of the App Service plan (number of
        /// VM's).
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets name of App Service Environment where app or App
        /// Service plan should be created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Capacity < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Capacity", 1);
            }
        }
    }
}
