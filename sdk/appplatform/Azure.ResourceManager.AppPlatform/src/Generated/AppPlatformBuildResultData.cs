// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformBuildResult data model.
    /// Build result resource payload
    /// </summary>
    public partial class AppPlatformBuildResultData : ResourceData
    {
        /// <summary> Initializes a new instance of AppPlatformBuildResultData. </summary>
        public AppPlatformBuildResultData()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformBuildResultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the build result resource. </param>
        internal AppPlatformBuildResultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformBuildResultProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the build result resource. </summary>
        public AppPlatformBuildResultProperties Properties { get; set; }
    }
}
