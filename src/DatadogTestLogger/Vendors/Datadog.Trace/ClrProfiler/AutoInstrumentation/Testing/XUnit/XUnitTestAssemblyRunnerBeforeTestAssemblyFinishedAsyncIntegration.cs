//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="XUnitTestAssemblyRunnerBeforeTestAssemblyFinishedAsyncIntegration.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using DatadogTestLogger.Vendors.Datadog.Trace.Ci;
using DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.CallTarget;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Testing.XUnit;

/// <summary>
/// Xunit.Sdk.TestAssemblyRunner`1.BeforeTestAssemblyFinishedAsync calltarget instrumentation
/// </summary>
[InstrumentMethod(
    AssemblyNames = new[] { "xunit.execution.dotnet", "xunit.execution.desktop" },
    TypeName = "Xunit.Sdk.TestAssemblyRunner`1",
    MethodName = "BeforeTestAssemblyFinishedAsync",
    ReturnTypeName = ClrNames.Task,
    ParameterTypeNames = new string[0],
    MinimumVersion = "2.2.0",
    MaximumVersion = "2.*.*",
    IntegrationName = XUnitIntegration.IntegrationName)]
[InstrumentMethod(
    AssemblyNames = new[] { "xunit.execution.dotnet", "xunit.execution.desktop" },
    TypeName = "Xunit.Sdk.TestAssemblyRunner`1",
    MethodName = "BeforeTestAssemblyFinishedAsync",
    ReturnTypeName = ClrNames.Task,
    ParameterTypeNames = new string[0],
    MinimumVersion = "2.2.0",
    MaximumVersion = "2.*.*",
    IntegrationName = XUnitIntegration.IntegrationName,
    CallTargetIntegrationType = IntegrationType.Derived)]
[Browsable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal static class XUnitTestAssemblyRunnerBeforeTestAssemblyFinishedAsyncIntegration
{
    /// <summary>
    /// OnAsyncMethodEnd callback
    /// </summary>
    /// <typeparam name="TTarget">Type of the target</typeparam>
    /// <typeparam name="TReturn">Type of the return type</typeparam>
    /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
    /// <param name="returnValue">Return value</param>
    /// <param name="exception">Exception instance in case the original code threw an exception.</param>
    /// <param name="state">Calltarget state value</param>
    /// <returns>A response value, in an async scenario will be T of Task of T</returns>
    internal static async Task<TReturn> OnAsyncMethodEnd<TTarget, TReturn>(TTarget instance, TReturn returnValue, Exception exception, CallTargetState state)
    {
        if (TestModule.Current is { } testModule)
        {
            await testModule.CloseAsync().ConfigureAwait(false);
        }

        return returnValue;
    }
}
