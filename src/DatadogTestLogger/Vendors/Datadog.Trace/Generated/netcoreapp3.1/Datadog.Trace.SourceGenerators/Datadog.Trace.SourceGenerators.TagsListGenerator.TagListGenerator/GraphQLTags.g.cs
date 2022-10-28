//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <auto-generated/>
#nullable enable

using Datadog.Trace.Vendors.Datadog.Trace.Processors;
using Datadog.Trace.Vendors.Datadog.Trace.Tagging;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.GraphQL
{
    partial class GraphQLTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // SourceBytes = System.Text.Encoding.UTF8.GetBytes("graphql.source");
        private static readonly byte[] SourceBytes = new byte[] { 103, 114, 97, 112, 104, 113, 108, 46, 115, 111, 117, 114, 99, 101 };
        // OperationNameBytes = System.Text.Encoding.UTF8.GetBytes("graphql.operation.name");
        private static readonly byte[] OperationNameBytes = new byte[] { 103, 114, 97, 112, 104, 113, 108, 46, 111, 112, 101, 114, 97, 116, 105, 111, 110, 46, 110, 97, 109, 101 };
        // OperationTypeBytes = System.Text.Encoding.UTF8.GetBytes("graphql.operation.type");
        private static readonly byte[] OperationTypeBytes = new byte[] { 103, 114, 97, 112, 104, 113, 108, 46, 111, 112, 101, 114, 97, 116, 105, 111, 110, 46, 116, 121, 112, 101 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "graphql.source" => Source,
                "graphql.operation.name" => OperationName,
                "graphql.operation.type" => OperationType,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "graphql.source": 
                    Source = value;
                    break;
                case "graphql.operation.name": 
                    OperationName = value;
                    break;
                case "graphql.operation.type": 
                    OperationType = value;
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

            if (InstrumentationName is not null)
            {
                processor.Process(new TagItem<string>("component", InstrumentationName, InstrumentationNameBytes));
            }

            if (Source is not null)
            {
                processor.Process(new TagItem<string>("graphql.source", Source, SourceBytes));
            }

            if (OperationName is not null)
            {
                processor.Process(new TagItem<string>("graphql.operation.name", OperationName, OperationNameBytes));
            }

            if (OperationType is not null)
            {
                processor.Process(new TagItem<string>("graphql.operation.type", OperationType, OperationTypeBytes));
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

            if (InstrumentationName is not null)
            {
                sb.Append("component (tag):")
                  .Append(InstrumentationName)
                  .Append(',');
            }

            if (Source is not null)
            {
                sb.Append("graphql.source (tag):")
                  .Append(Source)
                  .Append(',');
            }

            if (OperationName is not null)
            {
                sb.Append("graphql.operation.name (tag):")
                  .Append(OperationName)
                  .Append(',');
            }

            if (OperationType is not null)
            {
                sb.Append("graphql.operation.type (tag):")
                  .Append(OperationType)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}
