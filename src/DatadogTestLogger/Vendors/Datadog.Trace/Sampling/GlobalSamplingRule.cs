//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="GlobalSamplingRule.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using DatadogTestLogger.Vendors.Datadog.Trace.Logging;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Sampling
{
    internal class GlobalSamplingRule : ISamplingRule
    {
        private static readonly IDatadogLogger Log = DatadogLogging.GetLoggerFor<GlobalSamplingRule>();

        private readonly float _globalRate;

        public GlobalSamplingRule(float rate)
        {
            _globalRate = rate;
        }

        public string RuleName => "global-rate-rule";

        /// <summary>
        /// Gets the priority which is one beneath custom rules.
        /// </summary>
        public int Priority => 0;

        public int SamplingMechanism => Datadog.Trace.Sampling.SamplingMechanism.TraceSamplingRule;

        public bool IsMatch(Span span)
        {
            return true;
        }

        public float GetSamplingRate(Span span)
        {
            Log.Debug("Using the global sampling rate: {Rate}", _globalRate);
            span.SetMetric(Metrics.SamplingRuleDecision, _globalRate);
            return _globalRate;
        }
    }
}
