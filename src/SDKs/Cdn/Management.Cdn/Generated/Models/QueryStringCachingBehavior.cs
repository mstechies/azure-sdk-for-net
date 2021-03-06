// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for QueryStringCachingBehavior.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryStringCachingBehavior
    {
        [EnumMember(Value = "IgnoreQueryString")]
        IgnoreQueryString,
        [EnumMember(Value = "BypassCaching")]
        BypassCaching,
        [EnumMember(Value = "UseQueryString")]
        UseQueryString,
        [EnumMember(Value = "NotSet")]
        NotSet
    }
}

