// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schedules applicable to a virtual machine. The schedules may have been
    /// defined on a VM or on lab level.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicableScheduleFragmentInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicableScheduleFragmentInner
        /// class.
        /// </summary>
        public ApplicableScheduleFragmentInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicableScheduleFragmentInner
        /// class.
        /// </summary>
        /// <param name="labVmsShutdown">The auto-shutdown schedule, if one has
        /// been set at the lab or lab resource level.</param>
        /// <param name="labVmsStartup">The auto-startup schedule, if one has
        /// been set at the lab or lab resource level.</param>
        public ApplicableScheduleFragmentInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ScheduleFragmentInner labVmsShutdown = default(ScheduleFragmentInner), ScheduleFragmentInner labVmsStartup = default(ScheduleFragmentInner))
            : base(location, id, name, type, tags)
        {
            LabVmsShutdown = labVmsShutdown;
            LabVmsStartup = labVmsStartup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the auto-shutdown schedule, if one has been set at the
        /// lab or lab resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsShutdown")]
        public ScheduleFragmentInner LabVmsShutdown { get; set; }

        /// <summary>
        /// Gets or sets the auto-startup schedule, if one has been set at the
        /// lab or lab resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsStartup")]
        public ScheduleFragmentInner LabVmsStartup { get; set; }

    }
}
