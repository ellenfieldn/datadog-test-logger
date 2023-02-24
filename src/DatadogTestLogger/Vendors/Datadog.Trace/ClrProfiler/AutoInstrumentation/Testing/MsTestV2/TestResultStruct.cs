//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="TestResultStruct.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using DatadogTestLogger.Vendors.Datadog.Trace.DuckTyping;

#pragma warning disable CS0649 // Field is never assigned to

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Testing.MsTestV2;

/// <summary>
/// TestResult ducktype struct
/// </summary>
[DuckCopy]
internal struct TestResultStruct
{
    /// <summary>
    /// Gets the outcome enum
    /// </summary>
    public UnitTestOutcome Outcome;

    /// <summary>
    /// Test failure exception
    /// </summary>
    public Exception TestFailureException;
}
