//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#if NETCOREAPP3_1_OR_GREATER && !NET6_0_OR_GREATER
// <auto-generated/>
#nullable enable

using DatadogTestLogger.Vendors.Datadog.Trace.Processors;
using DatadogTestLogger.Vendors.Datadog.Trace.Tagging;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    partial class AspNetCoreTags
    {
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // AspNetCoreRouteBytes = System.Text.Encoding.UTF8.GetBytes("aspnet_core.route");
        private static readonly byte[] AspNetCoreRouteBytes = new byte[] { 97, 115, 112, 110, 101, 116, 95, 99, 111, 114, 101, 46, 114, 111, 117, 116, 101 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "component" => InstrumentationName,
                "aspnet_core.route" => AspNetCoreRoute,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "aspnet_core.route": 
                    AspNetCoreRoute = value;
                    break;
                default: 
                    base.SetTag(key, value);
                    break;
            }
        }

        public override void EnumerateTags<TProcessor>(ref TProcessor processor)
        {
            if (InstrumentationName is not null)
            {
                processor.Process(new TagItem<string>("component", InstrumentationName, InstrumentationNameBytes));
            }

            if (AspNetCoreRoute is not null)
            {
                processor.Process(new TagItem<string>("aspnet_core.route", AspNetCoreRoute, AspNetCoreRouteBytes));
            }

            base.EnumerateTags(ref processor);
        }

        protected override void WriteAdditionalTags(System.Text.StringBuilder sb)
        {
            if (InstrumentationName is not null)
            {
                sb.Append("component (tag):")
                  .Append(InstrumentationName)
                  .Append(',');
            }

            if (AspNetCoreRoute is not null)
            {
                sb.Append("aspnet_core.route (tag):")
                  .Append(AspNetCoreRoute)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif