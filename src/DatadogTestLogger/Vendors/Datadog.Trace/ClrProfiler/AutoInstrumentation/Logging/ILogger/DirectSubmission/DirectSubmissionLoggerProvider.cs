//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="DirectSubmissionLoggerProvider.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable

using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using DatadogTestLogger.Vendors.Datadog.Trace.DuckTyping;
using DatadogTestLogger.Vendors.Datadog.Trace.Logging.DirectSubmission;
using DatadogTestLogger.Vendors.Datadog.Trace.Logging.DirectSubmission.Formatting;
using DatadogTestLogger.Vendors.Datadog.Trace.Logging.DirectSubmission.Sink;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.ILogger.DirectSubmission
{
    /// <summary>
    /// Duck type for ILoggerProvider
    /// </summary>
    [Microsoft.Extensions.Logging.ProviderAlias("Datadog")]
    internal class DirectSubmissionLoggerProvider
    {
        private readonly Func<string, DirectSubmissionLogger> _createLoggerFunc;
        private readonly ConcurrentDictionary<string, DirectSubmissionLogger> _loggers = new();
        private readonly IDatadogSink _sink;
        private readonly LogFormatter? _formatter;
        private readonly DirectSubmissionLogLevel _minimumLogLevel;
        private IExternalScopeProvider? _scopeProvider;

        internal DirectSubmissionLoggerProvider(IDatadogSink sink, DirectSubmissionLogLevel minimumLogLevel, IExternalScopeProvider? scopeProvider)
            : this(sink, formatter: null, minimumLogLevel, scopeProvider)
        {
        }

        // used for testing
        internal DirectSubmissionLoggerProvider(
            IDatadogSink sink,
            LogFormatter? formatter,
            DirectSubmissionLogLevel minimumLogLevel,
            IExternalScopeProvider? scopeProvider)
        {
            _sink = sink;
            _formatter = formatter;
            _minimumLogLevel = minimumLogLevel;
            _createLoggerFunc = CreateLoggerImplementation;
            _scopeProvider = scopeProvider;
        }

        /// <summary>
        /// Creates a new <see cref="ILogger"/> instance.
        /// </summary>
        /// <param name="categoryName">The category name for messages produced by the logger.</param>
        /// <returns>The instance of <see cref="ILogger"/> that was created.</returns>
        [DuckReverseMethod]
        public DirectSubmissionLogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, _createLoggerFunc);
        }

        private DirectSubmissionLogger CreateLoggerImplementation(string name)
        {
            return new DirectSubmissionLogger(name, _scopeProvider, _sink, _formatter, _minimumLogLevel);
        }

        /// <inheritdoc cref="IDisposable.Dispose"/>
        [DuckReverseMethod]
        public void Dispose()
        {
        }

        /// <summary>
        /// Method for ISupportExternalScope
        /// </summary>
        /// <param name="scopeProvider">The provider of scope data</param>
        [DuckReverseMethod(ParameterTypeNames = new[] { "Microsoft.Extensions.Logging.IExternalScopeProvider, Microsoft.Extensions.Logging.Abstractions" })]
        public void SetScopeProvider(IExternalScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }
    }
}
