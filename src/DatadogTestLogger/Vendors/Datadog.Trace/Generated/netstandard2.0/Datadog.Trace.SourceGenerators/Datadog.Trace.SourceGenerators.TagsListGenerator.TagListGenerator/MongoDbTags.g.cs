//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#if !NETFRAMEWORK && !NETCOREAPP3_1_OR_GREATER
// <auto-generated/>
#nullable enable

using DatadogTestLogger.Vendors.Datadog.Trace.Processors;
using DatadogTestLogger.Vendors.Datadog.Trace.Tagging;

namespace DatadogTestLogger.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.MongoDb
{
    partial class MongoDbTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // DbNameBytes = System.Text.Encoding.UTF8.GetBytes("db.name");
        private static readonly byte[] DbNameBytes = new byte[] { 100, 98, 46, 110, 97, 109, 101 };
        // QueryBytes = System.Text.Encoding.UTF8.GetBytes("mongodb.query");
        private static readonly byte[] QueryBytes = new byte[] { 109, 111, 110, 103, 111, 100, 98, 46, 113, 117, 101, 114, 121 };
        // CollectionBytes = System.Text.Encoding.UTF8.GetBytes("mongodb.collection");
        private static readonly byte[] CollectionBytes = new byte[] { 109, 111, 110, 103, 111, 100, 98, 46, 99, 111, 108, 108, 101, 99, 116, 105, 111, 110 };
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
                "db.name" => DbName,
                "mongodb.query" => Query,
                "mongodb.collection" => Collection,
                "out.host" => Host,
                "out.port" => Port,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "db.name": 
                    DbName = value;
                    break;
                case "mongodb.query": 
                    Query = value;
                    break;
                case "mongodb.collection": 
                    Collection = value;
                    break;
                case "out.host": 
                    Host = value;
                    break;
                case "out.port": 
                    Port = value;
                    break;
                case "span.kind": 
                case "component": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(MongoDbTags));
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

            if (DbName is not null)
            {
                processor.Process(new TagItem<string>("db.name", DbName, DbNameBytes));
            }

            if (Query is not null)
            {
                processor.Process(new TagItem<string>("mongodb.query", Query, QueryBytes));
            }

            if (Collection is not null)
            {
                processor.Process(new TagItem<string>("mongodb.collection", Collection, CollectionBytes));
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

            if (DbName is not null)
            {
                sb.Append("db.name (tag):")
                  .Append(DbName)
                  .Append(',');
            }

            if (Query is not null)
            {
                sb.Append("mongodb.query (tag):")
                  .Append(Query)
                  .Append(',');
            }

            if (Collection is not null)
            {
                sb.Append("mongodb.collection (tag):")
                  .Append(Collection)
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