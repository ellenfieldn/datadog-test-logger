//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ClientStatsPayload.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.Threading;

namespace Datadog.Trace.Vendors.Datadog.Trace.Agent
{
    internal class ClientStatsPayload
    {
        private long _sequence;

        public string HostName { get; set; }

        public string Environment { get; set; }

        public string Version { get; set; }

        public long GetSequenceNumber() => Interlocked.Increment(ref _sequence);
    }
}
