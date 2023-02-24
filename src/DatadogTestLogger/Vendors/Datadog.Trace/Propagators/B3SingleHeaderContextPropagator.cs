//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="B3SingleHeaderContextPropagator.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;
using DatadogTestLogger.Vendors.Datadog.Trace.Util;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Propagators
{
    internal class B3SingleHeaderContextPropagator : IContextInjector, IContextExtractor
    {
        /// <summary>
        /// B3 single header
        /// </summary>
        public const string B3 = "b3";

        public static readonly B3SingleHeaderContextPropagator Instance = new();

        private B3SingleHeaderContextPropagator()
        {
        }

        public void Inject<TCarrier, TCarrierSetter>(SpanContext context, TCarrier carrier, TCarrierSetter carrierSetter)
            where TCarrierSetter : struct, ICarrierSetter<TCarrier>
        {
            var traceId = IsValidTraceId(context.RawTraceId) ? context.RawTraceId : context.TraceId.ToString("x16");
            var spanId = IsValidSpanId(context.RawSpanId) ? context.RawSpanId : context.SpanId.ToString("x16");
            var samplingPriority = context.TraceContext?.SamplingPriority ?? context.SamplingPriority;
            var sampled = samplingPriority > 0 ? "1" : "0";
            carrierSetter.Set(carrier, B3, $"{traceId}-{spanId}-{sampled}");
        }

        public bool TryExtract<TCarrier, TCarrierGetter>(TCarrier carrier, TCarrierGetter carrierGetter, out SpanContext? spanContext)
            where TCarrierGetter : struct, ICarrierGetter<TCarrier>
        {
            spanContext = null;

            var brValue = ParseUtility.ParseString(carrier, carrierGetter, B3)?.Trim();
            if (!string.IsNullOrEmpty(brValue))
            {
                // We found a trace parent (we are reading from the Http Headers)

                // 80f198ee56343ba864fe8b2a57d3eff7-e457b5a2e4d86bd1-1-05e3ac9a4f6e3b90
                // 80f198ee56343ba864fe8b2a57d3eff7-e457b5a2e4d86bd1-1
                // e457b5a2e4d86bd1-e457b5a2e4d86bd1-1-05e3ac9a4f6e3b90
                // e457b5a2e4d86bd1-e457b5a2e4d86bd1-1
                if (brValue!.Length is not 68 and not 51 and not 52 and not 35)
                {
                    return false;
                }

#if NETCOREAPP3_1_OR_GREATER
                ReadOnlySpan<char> rawTraceId;
                ReadOnlySpan<char> rawSpanId;
                char rawSampled;

                if (brValue.Length > 50 && brValue[32] == '-' && brValue[49] == '-')
                {
                    // 128 bits trace id
                    rawTraceId = brValue.AsSpan(0, 32);
                    rawSpanId = brValue.AsSpan(33, 16);
                    rawSampled = brValue[50];
                }
                else if (brValue.Length > 34 && brValue[16] == '-' && brValue[33] == '-')
                {
                    // 64 bits trace id
                    rawTraceId = brValue.AsSpan(0, 16);
                    rawSpanId = brValue.AsSpan(17, 16);
                    rawSampled = brValue[34];
                }
                else
                {
                    return false;
                }

                ulong traceId;

                var success = rawTraceId.Length == 32 ?
                                  HexString.TryParseUInt64(rawTraceId.Slice(16), out traceId) :
                                  HexString.TryParseUInt64(rawTraceId, out traceId);

                if (!success || traceId == 0)
                {
                    return false;
                }

                if (!HexString.TryParseUInt64(rawSpanId, out var parentId))
                {
                    parentId = 0;
                }

                var samplingPriority = rawSampled == '1' ? 1 : 0;
                spanContext = new SpanContext(traceId, parentId, samplingPriority, serviceName: null, null, rawTraceId.ToString(), rawSpanId.ToString());
#else
                string? rawTraceId = null;
                string? rawSpanId = null;
                char rawSampled = '0';
                if (brValue.Length > 50 && brValue[32] == '-' && brValue[49] == '-')
                {
                    // 128 bits trace id
                    rawTraceId = brValue.Substring(0, 32);
                    rawSpanId = brValue.Substring(33, 16);
                    rawSampled = brValue[50];
                }
                else if (brValue.Length > 34 && brValue[16] == '-' && brValue[33] == '-')
                {
                    // 64 bits trace id
                    rawTraceId = brValue.Substring(0, 16);
                    rawSpanId = brValue.Substring(17, 16);
                    rawSampled = brValue[34];
                }
                else
                {
                    return false;
                }

                ulong traceId;

                var success = rawTraceId.Length == 32 ?
                                  HexString.TryParseUInt64(rawTraceId.Substring(16), out traceId) :
                                  HexString.TryParseUInt64(rawTraceId, out traceId);

                if (!success || traceId == 0)
                {
                    return false;
                }

                if (!HexString.TryParseUInt64(rawSpanId, out var parentId))
                {
                    parentId = 0;
                }

                var samplingPriority = rawSampled == '1' ? 1 : 0;
                spanContext = new SpanContext(traceId, parentId, samplingPriority, serviceName: null, null, rawTraceId, rawSpanId);
#endif

                return true;
            }

            return false;
        }

        private static bool IsValidTraceId([NotNullWhen(true)] string? traceId)
        {
            if (string.IsNullOrEmpty(traceId))
            {
                return false;
            }

            if (traceId!.Length != 16 && traceId!.Length != 32)
            {
                return false;
            }

            return true;
        }

        private static bool IsValidSpanId([NotNullWhen(true)] string? spanId)
        {
            if (string.IsNullOrEmpty(spanId))
            {
                return false;
            }

            if (spanId!.Length != 16)
            {
                return false;
            }

            return true;
        }
    }
}
