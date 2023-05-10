//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;
using System.Net;
using Mono.Unix;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Aggregator;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Transport;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Bufferize
{
    /// <summary>
    /// IStatsBufferizeFactory is a factory for StatsBufferize.
    /// It is used to test StatsBufferize.
    /// </summary>
    internal interface IStatsBufferizeFactory
    {
        StatsBufferize CreateStatsBufferize(
          StatsRouter statsRouter,
          int workerMaxItemCount,
          TimeSpan? blockingQueueTimeout,
          TimeSpan maxIdleWaitBeforeSending);

        StatsRouter CreateStatsRouter(
            Serializers serializers,
            BufferBuilder bufferBuilder,
            Aggregators optionalAggregators);

        ITransport CreateUDPTransport(IPEndPoint endPoint);

        ITransport CreateUnixDomainSocketTransport(
            UnixEndPoint endPoint,
            TimeSpan? udsBufferFullBlockDuration);

        ITransport CreateNamedPipeTransport(string pipeName);

        Telemetry CreateTelemetry(
            MetricSerializer metricSerializer,
            string assemblyVersion,
            TimeSpan flushInterval,
            ITransport transport,
            string[] globalTags);
    }
}