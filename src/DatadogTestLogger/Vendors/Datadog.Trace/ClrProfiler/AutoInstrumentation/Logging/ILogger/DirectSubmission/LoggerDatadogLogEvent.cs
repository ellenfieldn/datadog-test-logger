//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="LoggerDatadogLogEvent.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable

using System.Text;
using DatadogTestLogger.Vendors.Datadog.Trace.Logging.DirectSubmission.Formatting;
using DatadogTestLogger.Vendors.Datadog.Trace.Logging.DirectSubmission.Sink;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.ILogger.DirectSubmission
{
    internal class LoggerDatadogLogEvent : DatadogLogEvent
    {
        private readonly string? _serializedEvent;

        public LoggerDatadogLogEvent(string? serializedEvent)
        {
            _serializedEvent = serializedEvent;
        }

        public override void Format(StringBuilder sb, LogFormatter formatter)
        {
            sb.Append(_serializedEvent);
        }
    }
}
