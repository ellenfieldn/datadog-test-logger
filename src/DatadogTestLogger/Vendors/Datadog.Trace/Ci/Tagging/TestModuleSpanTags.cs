//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="TestModuleSpanTags.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using DatadogTestLogger.Vendors.Datadog.Trace.Ci.Tags;
using DatadogTestLogger.Vendors.Datadog.Trace.SourceGenerators;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Ci.Tagging;

internal partial class TestModuleSpanTags : TestSessionSpanTags
{
    public TestModuleSpanTags()
    {
    }

    public TestModuleSpanTags(TestSessionSpanTags sessionTags)
    {
        SessionId = sessionTags.SessionId;
        Command = sessionTags.Command;
        WorkingDirectory = sessionTags.WorkingDirectory;
    }

    public ulong ModuleId { get; set; }

    [Tag(TestTags.Type)]
    public string Type { get; set; }

    [Tag(TestTags.Module)]
    public string Module { get; set; }

    [Tag(TestTags.Bundle)]
    public string Bundle => Module;

    [Tag(TestTags.Framework)]
    public string Framework { get; set; }

    [Tag(TestTags.FrameworkVersion)]
    public string FrameworkVersion { get; set; }

    [Tag(CommonTags.RuntimeName)]
    public string RuntimeName { get; set; }

    [Tag(CommonTags.RuntimeVersion)]
    public string RuntimeVersion { get; set; }

    [Tag(CommonTags.RuntimeArchitecture)]
    public string RuntimeArchitecture { get; set; }

    [Tag(CommonTags.OSArchitecture)]
    public string OSArchitecture { get; set; }

    [Tag(CommonTags.OSPlatform)]
    public string OSPlatform { get; set; }

    [Tag(CommonTags.OSVersion)]
    public string OSVersion { get; set; }
}
