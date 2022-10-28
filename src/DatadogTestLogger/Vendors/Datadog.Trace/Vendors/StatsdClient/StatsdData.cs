//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Bufferize;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Transport;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient
{
    internal class StatsdData : IDisposable
    {
        private ITransport _transport;
        private StatsBufferize _statsBufferize;

        public StatsdData(
            MetricsSender metricsSender,
            StatsBufferize statsBufferize,
            ITransport transport,
            Telemetry telemetry)
        {
            MetricsSender = metricsSender;
            Telemetry = telemetry;
            _statsBufferize = statsBufferize;
            _transport = transport;
        }

        public MetricsSender MetricsSender { get; private set; }

        public Telemetry Telemetry { get; private set; }

        public void Flush()
        {
            _statsBufferize?.Flush();
            Telemetry.Flush();
        }

        public void Dispose()
        {
            // _statsBufferize and _telemetry must be disposed before _statsSender to make
            // sure _statsSender does not received data when it is already disposed.

            Telemetry?.Dispose();
            Telemetry = null;

            _statsBufferize?.Dispose();
            _statsBufferize = null;

            _transport?.Dispose();
            _transport = null;

            MetricsSender = null;
        }
    }
}