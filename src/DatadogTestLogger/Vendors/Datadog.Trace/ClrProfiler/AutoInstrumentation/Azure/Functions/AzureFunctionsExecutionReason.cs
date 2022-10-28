//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="AzureFunctionsExecutionReason.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#if !NETFRAMEWORK
namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Azure.Functions
{
    /// <summary>
    /// Enum for ducktyping
    /// </summary>
    internal enum AzureFunctionsExecutionReason
    {
        /// <summary>Indicates a function executed because of an automatic trigger.</summary>
        AutomaticTrigger,

        /// <summary>Indicates a function executed because of a programmatic host call.</summary>
        HostCall,

        /// <summary>Indicates a function executed because of a request from a dashboard user.</summary>
        Dashboard
    }
}
#endif
