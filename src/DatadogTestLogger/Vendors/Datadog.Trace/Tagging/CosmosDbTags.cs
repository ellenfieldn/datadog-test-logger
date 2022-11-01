//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="CosmosDbTags.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.Linq;
using DatadogTestLogger.Vendors.Datadog.Trace.Configuration;
using DatadogTestLogger.Vendors.Datadog.Trace.SourceGenerators;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    internal partial class CosmosDbTags : InstrumentationTags
    {
        [Tag(Trace.Tags.SpanKind)]
        public override string SpanKind => SpanKinds.Client;

        [Tag(Trace.Tags.InstrumentationName)]
        public string InstrumentationName => nameof(IntegrationId.CosmosDb);

        [Tag(Trace.Tags.DbType)]
        public string DbType => "cosmosdb";

        [Tag(Trace.Tags.CosmosDbContainer)]
        public string ContainerId { get; set; }

        [Tag(Trace.Tags.DbName)]
        public string DatabaseId { get; set; }

        [Tag(Trace.Tags.OutHost)]
        public string Host { get; set; }
    }
}
