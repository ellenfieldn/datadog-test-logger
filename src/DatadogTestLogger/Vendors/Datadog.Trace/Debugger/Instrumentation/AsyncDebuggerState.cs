//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="AsyncDebuggerState.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Debugger.Instrumentation
{
    /// <summary>
    /// A state that is used in async continuation
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal struct AsyncDebuggerState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDebuggerState"/> struct.
        /// </summary>
        public AsyncDebuggerState()
        {
            SpanState = null;
            LogState = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDebuggerState"/> struct.
        /// </summary>
        /// <param name="spanState">The span state</param>
        public AsyncDebuggerState(SpanDebuggerState spanState)
        {
            SpanState = spanState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDebuggerState"/> struct.
        /// </summary>
        /// <param name="logState">The log state</param>
        public AsyncDebuggerState(AsyncMethodDebuggerState logState)
        {
            LogState = logState;
        }

        /// <summary>
        /// Gets or sets the span state
        /// </summary>
        public SpanDebuggerState? SpanState { get; set; }

        /// <summary>
        /// Gets or sets the log state
        /// </summary>
        public AsyncMethodDebuggerState LogState { get; set; }
    }
}
