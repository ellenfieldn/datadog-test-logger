//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="BasicDeliverAsyncIntegration.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.ComponentModel;
using Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.CallTarget;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.RabbitMQ
{
    /// <summary>
    /// RabbitMQ.Client.IAsyncBasicConsumer.BasicDeliver calltarget instrumentation
    /// </summary>
    [InstrumentMethod(
        AssemblyName = "RabbitMQ.Client",
        TypeName = "RabbitMQ.Client.IAsyncBasicConsumer",
        MethodName = "HandleBasicDeliver",
        ReturnTypeName = ClrNames.Task,
        ParameterTypeNames = new[] { ClrNames.String, ClrNames.UInt64, ClrNames.Bool, ClrNames.String, ClrNames.String, RabbitMQConstants.IBasicPropertiesTypeName, ClrNames.Ignore },
        MinimumVersion = "3.6.9",
        MaximumVersion = "6.*.*",
        IntegrationName = RabbitMQConstants.IntegrationName,
        CallTargetIntegrationType = IntegrationType.Interface)]
    [InstrumentMethod(
        AssemblyName = "RabbitMQ.Client",
        TypeName = "RabbitMQ.Client.AsyncDefaultBasicConsumer",
        MethodName = "HandleBasicDeliver",
        ReturnTypeName = ClrNames.Task,
        ParameterTypeNames = new[] { ClrNames.String, ClrNames.UInt64, ClrNames.Bool, ClrNames.String, ClrNames.String, RabbitMQConstants.IBasicPropertiesTypeName, ClrNames.Ignore },
        MinimumVersion = "3.6.9",
        MaximumVersion = "6.*.*",
        IntegrationName = RabbitMQConstants.IntegrationName,
        CallTargetIntegrationType = IntegrationType.Derived)]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class BasicDeliverAsyncIntegration
    {
        /// <summary>
        /// OnMethodBegin callback
        /// </summary>
        /// <typeparam name="TTarget">Type of the target</typeparam>
        /// <typeparam name="TBasicProperties">Type of the message properties</typeparam>
        /// <typeparam name="TBody">Type of the message body</typeparam>
        /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
        /// <param name="consumerTag">The original consumerTag argument</param>
        /// <param name="deliveryTag">The original deliveryTag argument</param>
        /// <param name="redelivered">The original redelivered argument</param>
        /// <param name="exchange">Name of the exchange.</param>
        /// <param name="routingKey">The routing key.</param>
        /// <param name="basicProperties">The message properties.</param>
        /// <param name="body">The message body.</param>
        /// <returns>Calltarget state value</returns>
        internal static CallTargetState OnMethodBegin<TTarget, TBasicProperties, TBody>(TTarget instance, string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, TBasicProperties basicProperties, TBody body)
            where TBasicProperties : IBasicProperties
            where TBody : IBody // ReadOnlyMemory<byte> body in 6.0.0
        {
            return RabbitMQIntegration.BasicDeliver_OnMethodBegin(instance, consumerTag, deliveryTag, redelivered, exchange, routingKey, basicProperties, body);
        }

        /// <summary>
        /// OnAsyncMethodEnd callback
        /// </summary>
        /// <typeparam name="TTarget">Type of the target</typeparam>
        /// <typeparam name="TReturn">Type of the result value, in an async scenario will be T of Task of T</typeparam>
        /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
        /// <param name="returnValue">Response instance</param>
        /// <param name="exception">Exception instance in case the original code threw an exception.</param>
        /// <param name="state">Calltarget state value</param>
        /// <returns>A response value, in an async scenario will be T of Task of T</returns>
        internal static TReturn OnAsyncMethodEnd<TTarget, TReturn>(TTarget instance, TReturn returnValue, Exception exception, in CallTargetState state)
        {
            state.Scope.DisposeWithException(exception);
            return returnValue;
        }
    }
}
