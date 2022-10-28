//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ResultData.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.Collections.Generic;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.Newtonsoft.Json;

namespace Datadog.Trace.Vendors.Datadog.Trace.AppSec.Waf.ReturnTypes.Managed
{
    internal class ResultData
    {
        [JsonProperty("ret_code")]
        internal int RetCode { get; set; }

        [JsonProperty("flow")]
        internal string Flow { get; set; }

        [JsonProperty("step")]
        internal string Step { get; set; }

        [JsonProperty("rule")]
        internal string Rule { get; set; }

        [JsonProperty("filter")]
        internal List<Filter> Filter { get; set; }
    }
}
