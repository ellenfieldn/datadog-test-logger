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
    partial class CouchbaseTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // OperationCodeBytes = System.Text.Encoding.UTF8.GetBytes("couchbase.operation.code");
        private static readonly byte[] OperationCodeBytes = new byte[] { 99, 111, 117, 99, 104, 98, 97, 115, 101, 46, 111, 112, 101, 114, 97, 116, 105, 111, 110, 46, 99, 111, 100, 101 };
        // BucketBytes = System.Text.Encoding.UTF8.GetBytes("couchbase.operation.bucket");
        private static readonly byte[] BucketBytes = new byte[] { 99, 111, 117, 99, 104, 98, 97, 115, 101, 46, 111, 112, 101, 114, 97, 116, 105, 111, 110, 46, 98, 117, 99, 107, 101, 116 };
        // KeyBytes = System.Text.Encoding.UTF8.GetBytes("couchbase.operation.key");
        private static readonly byte[] KeyBytes = new byte[] { 99, 111, 117, 99, 104, 98, 97, 115, 101, 46, 111, 112, 101, 114, 97, 116, 105, 111, 110, 46, 107, 101, 121 };
        // HostBytes = System.Text.Encoding.UTF8.GetBytes("out.host");
        private static readonly byte[] HostBytes = new byte[] { 111, 117, 116, 46, 104, 111, 115, 116 };
        // PortBytes = System.Text.Encoding.UTF8.GetBytes("out.port");
        private static readonly byte[] PortBytes = new byte[] { 111, 117, 116, 46, 112, 111, 114, 116 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "couchbase.operation.code" => OperationCode,
                "couchbase.operation.bucket" => Bucket,
                "couchbase.operation.key" => Key,
                "out.host" => Host,
                "out.port" => Port,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "couchbase.operation.code": 
                    OperationCode = value;
                    break;
                case "couchbase.operation.bucket": 
                    Bucket = value;
                    break;
                case "couchbase.operation.key": 
                    Key = value;
                    break;
                case "out.host": 
                    Host = value;
                    break;
                case "out.port": 
                    Port = value;
                    break;
                case "span.kind": 
                case "component": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(CouchbaseTags));
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

            if (OperationCode is not null)
            {
                processor.Process(new TagItem<string>("couchbase.operation.code", OperationCode, OperationCodeBytes));
            }

            if (Bucket is not null)
            {
                processor.Process(new TagItem<string>("couchbase.operation.bucket", Bucket, BucketBytes));
            }

            if (Key is not null)
            {
                processor.Process(new TagItem<string>("couchbase.operation.key", Key, KeyBytes));
            }

            if (Host is not null)
            {
                processor.Process(new TagItem<string>("out.host", Host, HostBytes));
            }

            if (Port is not null)
            {
                processor.Process(new TagItem<string>("out.port", Port, PortBytes));
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

            if (OperationCode is not null)
            {
                sb.Append("couchbase.operation.code (tag):")
                  .Append(OperationCode)
                  .Append(',');
            }

            if (Bucket is not null)
            {
                sb.Append("couchbase.operation.bucket (tag):")
                  .Append(Bucket)
                  .Append(',');
            }

            if (Key is not null)
            {
                sb.Append("couchbase.operation.key (tag):")
                  .Append(Key)
                  .Append(',');
            }

            if (Host is not null)
            {
                sb.Append("out.host (tag):")
                  .Append(Host)
                  .Append(',');
            }

            if (Port is not null)
            {
                sb.Append("out.port (tag):")
                  .Append(Port)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif