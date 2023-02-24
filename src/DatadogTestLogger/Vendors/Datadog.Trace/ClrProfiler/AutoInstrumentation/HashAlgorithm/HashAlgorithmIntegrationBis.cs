//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="HashAlgorithmIntegrationBis.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#if !NETFRAMEWORK

#nullable enable

using System;
using System.ComponentModel;
using System.Security.Cryptography;
using DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.CallTarget;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.HashAlgorithm;

/// <summary>
/// System.Security.Cryptography.HashAlgorithm instrumentation
/// </summary>
[InstrumentMethod(
   AssemblyNames = new[] { "System.Security.Cryptography.Primitives" },
   TypeNames = new[] { "System.Security.Cryptography.HashAlgorithm" },
   ParameterTypeNames = new[] { ClrNames.Stream },
   MethodName = "ComputeHash",
   ReturnTypeName = ClrNames.ByteArray,
   MinimumVersion = "1.0.0",
   MaximumVersion = "6.*.*",
   InstrumentationCategory = InstrumentationCategory.Iast,
   IntegrationName = nameof(Configuration.IntegrationId.HashAlgorithm))]
[InstrumentMethod(
   AssemblyNames = new[] { "System.Security.Cryptography.Primitives" },
   TypeNames = new[] { "System.Security.Cryptography.HashAlgorithm" },
   ParameterTypeNames = new[] { ClrNames.ByteArray },
   MethodName = "ComputeHash",
   ReturnTypeName = ClrNames.ByteArray,
   MinimumVersion = "1.0.0",
   MaximumVersion = "6.*.*",
   InstrumentationCategory = InstrumentationCategory.Iast,
   IntegrationName = nameof(Configuration.IntegrationId.HashAlgorithm))]
[InstrumentMethod(
    AssemblyNames = new[] { "System.Security.Cryptography" },
    TypeNames = new[] { "System.Security.Cryptography.HashAlgorithm" },
    ParameterTypeNames = new[] { ClrNames.Stream },
    MethodName = "ComputeHash",
    ReturnTypeName = ClrNames.ByteArray,
    MinimumVersion = "7.0.0",
    MaximumVersion = "7.*.*",
    InstrumentationCategory = InstrumentationCategory.Iast,
    IntegrationName = nameof(Configuration.IntegrationId.HashAlgorithm))]
[InstrumentMethod(
    AssemblyNames = new[] { "System.Security.Cryptography" },
    TypeNames = new[] { "System.Security.Cryptography.HashAlgorithm" },
    ParameterTypeNames = new[] { ClrNames.ByteArray },
    MethodName = "ComputeHash",
    ReturnTypeName = ClrNames.ByteArray,
    MinimumVersion = "7.0.0",
    MaximumVersion = "7.*.*",
    InstrumentationCategory = InstrumentationCategory.Iast,
    IntegrationName = nameof(Configuration.IntegrationId.HashAlgorithm))]
[Browsable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class HashAlgorithmIntegrationBis
{
    /// <summary>
    /// OnMethodBegin callback
    /// </summary>
    /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
    /// <param name="array">The input to compute the hash code for.</param>
    /// <typeparam name="TTarget">Type of the target</typeparam>
    /// <returns>Calltarget state value</returns>
    internal static CallTargetState OnMethodBegin<TTarget>(TTarget instance, object array)
    {
        return new CallTargetState(scope: HashAlgorithmIntegrationCommon.CreateScope(instance));
    }

    /// <summary>
    /// OnMethodEnd callback
    /// </summary>
    /// <typeparam name="TTarget">Type of the target</typeparam>
    /// <typeparam name="TReturn">Type of the return value</typeparam>
    /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
    /// <param name="returnValue">the return value processce</param>
    /// <param name="exception">Exception instance in case the original code threw an exception.</param>
    /// <param name="state">Calltarget state value</param>
    /// <returns>CallTargetReturn</returns>
    internal static CallTargetReturn<TReturn> OnMethodEnd<TTarget, TReturn>(TTarget instance, TReturn returnValue, Exception exception, CallTargetState state)
    {
        state.Scope.DisposeWithException(exception);
        return new CallTargetReturn<TReturn>(returnValue);
    }
}

#endif
