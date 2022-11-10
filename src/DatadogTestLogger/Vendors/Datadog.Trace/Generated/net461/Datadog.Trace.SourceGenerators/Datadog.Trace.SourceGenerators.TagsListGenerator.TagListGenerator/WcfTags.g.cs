//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#if NETFRAMEWORK
// <auto-generated/>
#nullable enable

using DatadogTestLogger.Vendors.Datadog.Trace.Processors;
using DatadogTestLogger.Vendors.Datadog.Trace.Tagging;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    partial class WcfTags
    {
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "component" => InstrumentationName,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "component": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(WcfTags));
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

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif