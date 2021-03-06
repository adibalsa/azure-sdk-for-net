// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ElevationLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElevationLevel
    {
        [EnumMember(Value = "nonAdmin")]
        NonAdmin,
        [EnumMember(Value = "admin")]
        Admin
    }
    internal static class ElevationLevelEnumExtension
    {
        internal static string ToSerializedValue(this ElevationLevel? value)  =>
            value == null ? null : ((ElevationLevel)value).ToSerializedValue();

        internal static string ToSerializedValue(this ElevationLevel value)
        {
            switch( value )
            {
                case ElevationLevel.NonAdmin:
                    return "nonAdmin";
                case ElevationLevel.Admin:
                    return "admin";
            }
            return null;
        }

        internal static ElevationLevel? ParseElevationLevel(this string value)
        {
            switch( value )
            {
                case "nonAdmin":
                    return ElevationLevel.NonAdmin;
                case "admin":
                    return ElevationLevel.Admin;
            }
            return null;
        }
    }
}
