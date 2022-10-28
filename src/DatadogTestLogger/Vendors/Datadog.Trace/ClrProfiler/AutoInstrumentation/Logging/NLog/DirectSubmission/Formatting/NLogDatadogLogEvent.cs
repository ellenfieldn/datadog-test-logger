//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="NLogDatadogLogEvent.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.Collections.Generic;
using System.Text;
using Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.NLog.DirectSubmission.Proxies;
using Datadog.Trace.Vendors.Datadog.Trace.Logging.DirectSubmission.Formatting;
using Datadog.Trace.Vendors.Datadog.Trace.Logging.DirectSubmission.Sink;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.NLog.DirectSubmission.Formatting
{
    internal class NLogDatadogLogEvent : DatadogLogEvent
    {
        private readonly string _serializedEvent;

        public NLogDatadogLogEvent(string serializedEvent)
        {
            _serializedEvent = serializedEvent;
        }

        public override void Format(StringBuilder sb, LogFormatter formatter)
        {
            sb.Append(_serializedEvent);
        }
    }
}
