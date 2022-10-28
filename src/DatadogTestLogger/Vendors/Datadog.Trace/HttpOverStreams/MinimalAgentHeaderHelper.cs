//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="MinimalAgentHeaderHelper.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable

using System.Linq;

namespace Datadog.Trace.Vendors.Datadog.Trace.HttpOverStreams;

internal class MinimalAgentHeaderHelper : HttpHeaderHelperBase
{
    private static string? _metadataHeaders = null;

    protected override string MetadataHeaders
    {
        get
        {
            if (_metadataHeaders == null)
            {
                var headers = AgentHttpHeaderNames.MinimalHeaders.Select(kvp => $"{kvp.Key}: {kvp.Value}{DatadogHttpValues.CrLf}");
                _metadataHeaders = string.Concat(headers);
            }

            return _metadataHeaders;
        }
    }

    protected override string ContentType => "application/json";
}
