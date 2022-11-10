//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#if NET6_0_OR_GREATER
// <auto-generated/>
#nullable enable

using DatadogTestLogger.Vendors.Datadog.Trace.Processors;
using DatadogTestLogger.Vendors.Datadog.Trace.Tagging;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    partial class ProcessCommandStartTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // EnvironmentVariablesBytes = System.Text.Encoding.UTF8.GetBytes("cmd.environment_variables");
        private static readonly byte[] EnvironmentVariablesBytes = new byte[] { 99, 109, 100, 46, 101, 110, 118, 105, 114, 111, 110, 109, 101, 110, 116, 95, 118, 97, 114, 105, 97, 98, 108, 101, 115 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "cmd.environment_variables" => EnvironmentVariables,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "cmd.environment_variables": 
                    EnvironmentVariables = value;
                    break;
                case "span.kind": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(ProcessCommandStartTags));
                    break;
                default: 
                    base.SetTag(key, value);
                    break;
            }
        }

        public override void EnumerateTags<TProcessor>(ref TProcessor processor)
        {
            if (SpanKind is not null)
            {
                processor.Process(new TagItem<string>("span.kind", SpanKind, SpanKindBytes));
            }

            if (EnvironmentVariables is not null)
            {
                processor.Process(new TagItem<string>("cmd.environment_variables", EnvironmentVariables, EnvironmentVariablesBytes));
            }

            base.EnumerateTags(ref processor);
        }

        protected override void WriteAdditionalTags(System.Text.StringBuilder sb)
        {
            if (SpanKind is not null)
            {
                sb.Append("span.kind (tag):")
                  .Append(SpanKind)
                  .Append(',');
            }

            if (EnvironmentVariables is not null)
            {
                sb.Append("cmd.environment_variables (tag):")
                  .Append(EnvironmentVariables)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif