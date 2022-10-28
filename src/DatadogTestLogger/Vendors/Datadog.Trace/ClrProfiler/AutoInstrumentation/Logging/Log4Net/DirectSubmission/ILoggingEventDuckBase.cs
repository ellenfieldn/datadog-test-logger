//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ILoggingEventDuckBase.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Collections;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Logging.Log4Net.DirectSubmission
{
    /// <summary>
    /// Duck type for LoggingEvent
    /// </summary>
    internal interface ILoggingEventDuckBase
    {
        /// <summary>
        /// Gets the name of the logger that logged the event.
        /// </summary>
        public string LoggerName { get; }

        /// <summary>
        /// Gets the Level of the logging event
        /// </summary>
        public LevelDuck Level { get; }

        /// <summary>
        /// Gets the application supplied message.
        /// </summary>
        public object MessageObject { get; }

        /// <summary>
        /// Gets the message, rendered through the RendererMap".
        /// </summary>
        public string RenderedMessage { get; }

        /// <summary>
        /// Gets the exception associated with the event
        /// </summary>
        public string GetExceptionString();

        /// <summary>
        /// Get all the composite properties in this event
        /// </summary>
        /// <returns>Dictionary containing all the properties</returns>
        public IDictionary GetProperties();
    }
}
