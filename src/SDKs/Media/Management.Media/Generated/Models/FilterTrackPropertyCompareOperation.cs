// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FilterTrackPropertyCompareOperation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterTrackPropertyCompareOperation
    {
        /// <summary>
        /// The equal operation.
        /// </summary>
        [EnumMember(Value = "Equal")]
        Equal,
        /// <summary>
        /// The not equal operation.
        /// </summary>
        [EnumMember(Value = "NotEqual")]
        NotEqual
    }
    internal static class FilterTrackPropertyCompareOperationEnumExtension
    {
        internal static string ToSerializedValue(this FilterTrackPropertyCompareOperation? value)
        {
            return value == null ? null : ((FilterTrackPropertyCompareOperation)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FilterTrackPropertyCompareOperation value)
        {
            switch( value )
            {
                case FilterTrackPropertyCompareOperation.Equal:
                    return "Equal";
                case FilterTrackPropertyCompareOperation.NotEqual:
                    return "NotEqual";
            }
            return null;
        }

        internal static FilterTrackPropertyCompareOperation? ParseFilterTrackPropertyCompareOperation(this string value)
        {
            switch( value )
            {
                case "Equal":
                    return FilterTrackPropertyCompareOperation.Equal;
                case "NotEqual":
                    return FilterTrackPropertyCompareOperation.NotEqual;
            }
            return null;
        }
    }
}
