//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="CachedMetadataHelper.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Reflection;
using System.Reflection.Emit;
using DatadogTestLogger.Vendors.Datadog.Trace.DuckTyping;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Grpc.GrpcLegacy.Client
{
    internal static class CachedMetadataHelper<TMarkerType>
    {
        private static Func<object> _activator;

        static CachedMetadataHelper()
        {
            CreateActivator(typeof(TMarkerType));
        }

        private static void CreateActivator(Type markerType)
        {
            var metadataType = markerType.Assembly.GetType("Grpc.Core.Metadata");

            ConstructorInfo ctor = metadataType.GetConstructor(System.Type.EmptyTypes);

            DynamicMethod createHeadersMethod = new DynamicMethod(
                $"GrpcCoreCachedMetadataHelper",
                metadataType,
                null,
                typeof(DuckType).Module,
                true);

            ILGenerator il = createHeadersMethod.GetILGenerator();
            il.Emit(OpCodes.Newobj, ctor);
            il.Emit(OpCodes.Ret);

            _activator = (Func<object>)createHeadersMethod.CreateDelegate(typeof(Func<object>));
        }

        /// <summary>
        /// Creates a Grpc.Core.Metadata object
        /// </summary>
        public static object CreateMetadata() => _activator();
    }
}
