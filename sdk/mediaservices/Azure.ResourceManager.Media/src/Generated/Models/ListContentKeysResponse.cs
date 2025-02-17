// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class of response for listContentKeys action. </summary>
    internal partial class ListContentKeysResponse
    {
        /// <summary> Initializes a new instance of ListContentKeysResponse. </summary>
        internal ListContentKeysResponse()
        {
            ContentKeys = new ChangeTrackingList<StreamingLocatorContentKey>();
        }

        /// <summary> Initializes a new instance of ListContentKeysResponse. </summary>
        /// <param name="contentKeys"> ContentKeys used by current Streaming Locator. </param>
        internal ListContentKeysResponse(IReadOnlyList<StreamingLocatorContentKey> contentKeys)
        {
            ContentKeys = contentKeys;
        }

        /// <summary> ContentKeys used by current Streaming Locator. </summary>
        public IReadOnlyList<StreamingLocatorContentKey> ContentKeys { get; }
    }
}
