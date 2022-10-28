//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="SyncCommandIntegration.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.ComponentModel;
using Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.CallTarget;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Aerospike
{
    /// <summary>
    /// SyncCommand ExecuteCommand calltarget instrumentation
    /// </summary>
    [InstrumentMethod(
        AssemblyName = "AerospikeClient",
        TypeName = "Aerospike.Client.SyncCommand",
        MethodName = "ExecuteCommand",
        ReturnTypeName = ClrNames.Void,
        ParameterTypeNames = new string[0],
        MinimumVersion = "4.0.0",
        MaximumVersion = "5.*.*",
        IntegrationName = AerospikeCommon.IntegrationName)]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class SyncCommandIntegration
    {
        /// <summary>
        /// OnMethodBegin callback
        /// </summary>
        /// <typeparam name="TTarget">Type of the target</typeparam>
        /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
        /// <returns>Calltarget state value</returns>
        internal static CallTargetState OnMethodBegin<TTarget>(TTarget instance)
        {
            return new CallTargetState(AerospikeCommon.CreateScope(Tracer.Instance, instance));
        }

        /// <summary>
        /// OnMethodEnd callback
        /// </summary>
        /// <typeparam name="TTarget">Type of the target</typeparam>
        /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
        /// <param name="exception">Exception instance in case the original code threw an exception.</param>
        /// <param name="state">Calltarget state value</param>
        /// <returns>A default CallTargetReturn to satisfy the CallTarget contract</returns>
        internal static CallTargetReturn OnMethodEnd<TTarget>(TTarget instance, Exception exception, in CallTargetState state)
        {
            state.Scope.DisposeWithException(exception);
            return CallTargetReturn.GetDefault();
        }
    }
}
