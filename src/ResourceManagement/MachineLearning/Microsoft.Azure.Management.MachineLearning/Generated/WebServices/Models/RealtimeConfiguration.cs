// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Holds the available configuration options for an Azure ML web service
    /// endpoint.
    /// </summary>
    public partial class RealtimeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the RealtimeConfiguration class.
        /// </summary>
        public RealtimeConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the RealtimeConfiguration class.
        /// </summary>
        /// <param name="maxConcurrentCalls">Maximum number of concurrent
        /// calls allowed on the realtime endpoint.</param>
        public RealtimeConfiguration(int? maxConcurrentCalls = default(int?))
        {
            MaxConcurrentCalls = maxConcurrentCalls;
        }

        /// <summary>
        /// Gets or sets maximum number of concurrent calls allowed on the
        /// realtime endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxConcurrentCalls")]
        public int? MaxConcurrentCalls { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.MaxConcurrentCalls > 200)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "MaxConcurrentCalls", 200);
            }
            if (this.MaxConcurrentCalls < 4)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "MaxConcurrentCalls", 4);
            }
        }
    }
}
