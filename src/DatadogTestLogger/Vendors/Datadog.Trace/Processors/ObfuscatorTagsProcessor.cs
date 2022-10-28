//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ObfuscatorTagsProcessor.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Datadog.Trace.Vendors.Datadog.Trace.Logging;

namespace Datadog.Trace.Vendors.Datadog.Trace.Processors
{
    internal class ObfuscatorTagsProcessor : ITagProcessor
    {
        private static readonly IDatadogLogger Log = DatadogLogging.GetLoggerFor<ObfuscatorTagsProcessor>();
        private readonly bool _redisObfuscationEnabled;

        public ObfuscatorTagsProcessor(bool redisObfuscationEnabled)
        {
            _redisObfuscationEnabled = redisObfuscationEnabled;
        }

        public void ProcessMeta(ref string key, ref string value)
        {
            // https://github.dev/DataDog/datadog-agent/blob/712c7a7835e0f5aaa47211c4d75a84323eed7fd9/pkg/trace/obfuscate/redis.go#L91
            if (_redisObfuscationEnabled && key == Trace.Tags.RedisRawCommand)
            {
                value = RedisObfuscationUtil.Obfuscate(value);
                Log.Debug("span.obfuscate: obfuscating `redis.raw_command` value");
            }
        }

        public void ProcessMetric(ref string key, ref double value)
        {
        }
    }
}
