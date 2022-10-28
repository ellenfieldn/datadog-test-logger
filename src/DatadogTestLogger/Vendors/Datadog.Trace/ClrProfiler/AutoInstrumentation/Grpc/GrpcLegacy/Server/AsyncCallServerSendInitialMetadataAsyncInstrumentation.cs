//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="AsyncCallServerSendInitialMetadataAsyncInstrumentation.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

using System.ComponentModel;
using Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.CallTarget;
using Datadog.Trace.Vendors.Datadog.Trace.DuckTyping;
using Datadog.Trace.Vendors.Datadog.Trace.ExtensionMethods;
using Datadog.Trace.Vendors.Datadog.Trace.Tagging;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Grpc.GrpcLegacy.Server
{
    /// <summary>
    /// Grpc.Core.Internal calltarget instrumentation
    /// </summary>
    [InstrumentMethod(
        AssemblyName = "Grpc.Core",
        TypeName = "Grpc.Core.Internal.AsyncCallServer`2",
        MethodName = "SendInitialMetadataAsync",
        ReturnTypeName = ClrNames.Task,
        ParameterTypeNames = new[] { "Grpc.Core.Metadata" },
        MinimumVersion = "2.0.0",
        MaximumVersion = "2.*.*",
        IntegrationName = nameof(Grpc))]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class AsyncCallServerSendInitialMetadataAsyncInstrumentation
    {
        internal static CallTargetState OnMethodBegin<TTarget, TMetadata>(TTarget instance, in TMetadata? headers)
        {
            var tracer = Tracer.Instance;
            if (tracer.ActiveScope is Scope { Span: { Tags: GrpcServerTags } span } && headers is not null)
            {
                var metadata = headers.DuckCast<IMetadata>();
                if (metadata.Count > 0)
                {
                    span.SetHeaderTags(new MetadataHeadersCollection(metadata), tracer.Settings.GrpcTags, defaultTagPrefix: GrpcCommon.ResponseMetadataTagPrefix);
                }
            }

            return CallTargetState.GetDefault();
        }
    }
}
