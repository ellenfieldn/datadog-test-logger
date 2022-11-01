//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="RabbitMQTags.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatadogTestLogger.Vendors.Datadog.Trace.SourceGenerators;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    internal partial class RabbitMQTags : InstrumentationTags
    {
        // For the sake of unit tests, define a default constructor with the default behavior,
        // though the RabbitMQ integration should use the constructor that takes a spanKind
        // so the setter is only invoked once
        public RabbitMQTags()
            : this(SpanKinds.Client)
        {
        }

        public RabbitMQTags(string spanKind)
        {
            SpanKind = spanKind;
        }

        [Tag(Trace.Tags.SpanKind)]
        public override string SpanKind { get; }

        [Tag(Trace.Tags.InstrumentationName)]
        public string InstrumentationName { get; set; }

        [Tag(Trace.Tags.AmqpCommand)]
        public string Command { get; set; }

        [Tag(Trace.Tags.AmqpDeliveryMode)]
        public string DeliveryMode { get; set; }

        [Tag(Trace.Tags.AmqpExchange)]
        public string Exchange { get; set; }

        [Tag(Trace.Tags.AmqpRoutingKey)]
        public string RoutingKey { get; set; }

        [Tag(Trace.Tags.MessageSize)]
        public string MessageSize { get; set; }

        [Tag(Trace.Tags.AmqpQueue)]
        public string Queue { get; set; }
    }
}
