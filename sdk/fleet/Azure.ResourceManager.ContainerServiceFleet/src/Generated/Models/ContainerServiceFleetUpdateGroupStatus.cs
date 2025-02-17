// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> The status of a UpdateGroup. </summary>
    public partial class ContainerServiceFleetUpdateGroupStatus
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetUpdateGroupStatus. </summary>
        internal ContainerServiceFleetUpdateGroupStatus()
        {
            Members = new ChangeTrackingList<MemberUpdateStatus>();
        }

        /// <summary> Initializes a new instance of ContainerServiceFleetUpdateGroupStatus. </summary>
        /// <param name="status"> The status of the UpdateGroup. </param>
        /// <param name="name"> The name of the UpdateGroup. </param>
        /// <param name="members"> The list of member this UpdateGroup updates. </param>
        internal ContainerServiceFleetUpdateGroupStatus(ContainerServiceFleetUpdateStatus status, string name, IReadOnlyList<MemberUpdateStatus> members)
        {
            Status = status;
            Name = name;
            Members = members;
        }

        /// <summary> The status of the UpdateGroup. </summary>
        public ContainerServiceFleetUpdateStatus Status { get; }
        /// <summary> The name of the UpdateGroup. </summary>
        public string Name { get; }
        /// <summary> The list of member this UpdateGroup updates. </summary>
        public IReadOnlyList<MemberUpdateStatus> Members { get; }
    }
}
