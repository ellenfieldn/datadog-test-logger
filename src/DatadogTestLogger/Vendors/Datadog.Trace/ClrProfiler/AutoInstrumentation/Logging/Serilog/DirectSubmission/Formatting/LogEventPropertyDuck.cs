//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="LogEventPropertyDuck.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using DatadogTestLogger.Vendors.Datadog.Trace.DuckTyping;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.Serilog.DirectSubmission.Formatting
{
    /// <summary>
    /// Duck type for LogEventProperty
    /// https://github.dev/serilog/serilog/blob/5e93d5045585095ebcb71ef340d6accd61f01670/src/Serilog/Events/LogEventProperty.cs
    /// </summary>
    [DuckCopy]
    internal struct LogEventPropertyDuck
    {
        /// <summary>
        /// Gets the name
        /// </summary>
        public string Name;

        /// <summary>
        /// Gets the value
        /// </summary>
        public object Value;
    }
}
