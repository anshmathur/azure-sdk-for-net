// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownMediaAssetTrackBase. </summary>
    internal partial class UnknownMediaAssetTrackBase : MediaAssetTrackBase
    {
        /// <summary> Initializes a new instance of UnknownMediaAssetTrackBase. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal UnknownMediaAssetTrackBase(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}
