//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="CICodeCoveragePayload.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Text;
using DatadogTestLogger.Vendors.Datadog.Trace.Agent;
using DatadogTestLogger.Vendors.Datadog.Trace.Agent.Transports;
using DatadogTestLogger.Vendors.Datadog.Trace.Ci.Agent.MessagePack;
using DatadogTestLogger.Vendors.Datadog.Trace.Ci.Configuration;
using DatadogTestLogger.Vendors.Datadog.Trace.Ci.Coverage.Models.Tests;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.MessagePack;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Ci.Agent.Payloads
{
    internal class CICodeCoveragePayload : MultipartPayload
    {
        private readonly IFormatterResolver _formatterResolver;

        public CICodeCoveragePayload(CIVisibilitySettings settings, int maxItemsPerPayload = DefaultMaxItemsPerPayload, int maxBytesPerPayload = DefaultMaxBytesPerPayload, IFormatterResolver formatterResolver = null)
            : base(settings, maxItemsPerPayload, maxBytesPerPayload, formatterResolver)
        {
            _formatterResolver = formatterResolver ?? CIFormatterResolver.Instance;

            // We call reset here to add the dummy event
            Reset();
        }

        public override string EventPlatformSubdomain => "event-platform-intake";

        public override string EventPlatformPath => "api/v2/citestcov";

        public override bool CanProcessEvent(IEvent @event)
        {
            return @event is TestCoverage;
        }

        protected override MultipartFormItem CreateMultipartFormItem(EventsBuffer<IEvent> eventsBuffer)
        {
            var totalEvents = eventsBuffer.Count;
            var index = Count;
            var eventInBytes = MessagePackSerializer.Serialize(new CoveragePayload(eventsBuffer), _formatterResolver);
            CIVisibility.Log.Debug<int, int>("CICodeCoveragePayload: Serialized {Count} test code coverage as a single multipart item with {Size} bytes.", eventsBuffer.Count, eventInBytes.Length);
            return new MultipartFormItem($"coverage{index}", MimeTypes.MsgPack, $"filecoverage{index}.msgpack", new ArraySegment<byte>(eventInBytes));
        }

        public override void Reset()
        {
            base.Reset();

            // This is a current limitation in the backend side
            // an "event" item must be included in each payload.
            // So here we are adding a dummy one.
            AddMultipartFormItem(
                new MultipartFormItem(
                    "event",
                    MimeTypes.Json,
                    "fileevent.json",
                    new ArraySegment<byte>(Encoding.UTF8.GetBytes("{\"dummy\": true}"))));
        }

        internal readonly struct CoveragePayload
        {
            public readonly EventsBuffer<IEvent> TestCoverageData;

            public CoveragePayload(EventsBuffer<IEvent> testCoverageData)
            {
                TestCoverageData = testCoverageData;
            }
        }
    }
}
