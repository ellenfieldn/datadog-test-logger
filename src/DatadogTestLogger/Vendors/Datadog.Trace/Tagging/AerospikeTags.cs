//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="AerospikeTags.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Datadog.Trace.Vendors.Datadog.Trace.SourceGenerators;

namespace Datadog.Trace.Vendors.Datadog.Trace.Tagging
{
    internal partial class AerospikeTags : InstrumentationTags
    {
        [Tag(Trace.Tags.SpanKind)]
        public override string SpanKind => SpanKinds.Client;

        [Tag(Trace.Tags.InstrumentationName)]
        public string InstrumentationName => "aerospike";

        [Tag(Trace.Tags.AerospikeKey)]
        public string Key { get; set; }

        [Tag(Trace.Tags.AerospikeNamespace)]
        public string Namespace { get; set; }

        [Tag(Trace.Tags.AerospikeSetName)]
        public string SetName { get; set; }

        [Tag(Trace.Tags.AerospikeUserKey)]
        public string UserKey { get; set; }
    }
}
