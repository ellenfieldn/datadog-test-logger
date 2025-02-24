//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="GlobalSettings.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

using DatadogTestLogger.Vendors.Datadog.Trace.Logging;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.Serilog.Events;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Configuration
{
    /// <summary>
    /// Contains global datadog settings.
    /// </summary>
    internal class GlobalSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSettings"/> class with default values.
        /// </summary>
        internal GlobalSettings()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSettings"/> class
        /// using the specified <see cref="IConfigurationSource"/> to initialize values.
        /// </summary>
        /// <param name="source">The <see cref="IConfigurationSource"/> to use when retrieving configuration values.</param>
        internal GlobalSettings(IConfigurationSource? source)
        {
            DebugEnabled = source?.GetBool(ConfigurationKeys.DebugEnabled) ??
                           // default value
                           false;

            DiagnosticSourceEnabled = source?.GetBool(ConfigurationKeys.DiagnosticSourceEnabled) ??
                                      // default value
                                      true;
        }

        /// <summary>
        /// Gets a value indicating whether debug mode is enabled.
        /// Default is <c>false</c>.
        /// Set in code via <see cref="SetDebugEnabled"/>
        /// </summary>
        /// <seealso cref="ConfigurationKeys.DebugEnabled"/>
        public bool DebugEnabled { get; private set; }

        /// <summary>
        /// Gets the global settings instance.
        /// </summary>
        internal static GlobalSettings Instance { get; private set; } = FromDefaultSources();

        /// <summary>
        /// Gets a value indicating whether the use
        /// of System.Diagnostics.DiagnosticSource is enabled.
        /// This value can only be set with environment variables
        /// or a configuration file, not through code.
        /// </summary>
        internal bool DiagnosticSourceEnabled { get; }

        /// <summary>
        /// Set whether debug mode is enabled.
        /// Affects the level of logs written to file.
        /// </summary>
        /// <param name="enabled">Whether debug is enabled.</param>
        public static void SetDebugEnabled(bool enabled)
        {
            Instance.DebugEnabled = enabled;

            if (enabled)
            {
                DatadogLogging.SetLogLevel(LogEventLevel.Debug);
            }
            else
            {
                DatadogLogging.UseDefaultLevel();
            }
        }

        /// <summary>
        /// Used to refresh global settings when environment variables or config sources change.
        /// This is not necessary if changes are set via code, only environment.
        /// </summary>
        public static void Reload()
        {
            DatadogLogging.Reset();
            GlobalConfigurationSource.Reload();
            Instance = FromDefaultSources();
        }

        /// <summary>
        /// Create a <see cref="GlobalSettings"/> populated from the default sources
        /// returned by <see cref="GlobalConfigurationSource.Instance"/>.
        /// </summary>
        /// <returns>A <see cref="TracerSettings"/> populated from the default sources.</returns>
        public static GlobalSettings FromDefaultSources()
        {
            return new GlobalSettings(GlobalConfigurationSource.Instance);
        }
    }
}
