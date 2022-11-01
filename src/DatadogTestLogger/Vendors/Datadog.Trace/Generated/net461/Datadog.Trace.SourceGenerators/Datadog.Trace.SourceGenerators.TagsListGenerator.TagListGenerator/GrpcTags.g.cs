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
    partial class GrpcTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // MethodKindBytes = System.Text.Encoding.UTF8.GetBytes("grpc.method.kind");
        private static readonly byte[] MethodKindBytes = new byte[] { 103, 114, 112, 99, 46, 109, 101, 116, 104, 111, 100, 46, 107, 105, 110, 100 };
        // MethodNameBytes = System.Text.Encoding.UTF8.GetBytes("grpc.method.name");
        private static readonly byte[] MethodNameBytes = new byte[] { 103, 114, 112, 99, 46, 109, 101, 116, 104, 111, 100, 46, 110, 97, 109, 101 };
        // MethodPathBytes = System.Text.Encoding.UTF8.GetBytes("grpc.method.path");
        private static readonly byte[] MethodPathBytes = new byte[] { 103, 114, 112, 99, 46, 109, 101, 116, 104, 111, 100, 46, 112, 97, 116, 104 };
        // MethodPackageBytes = System.Text.Encoding.UTF8.GetBytes("grpc.method.package");
        private static readonly byte[] MethodPackageBytes = new byte[] { 103, 114, 112, 99, 46, 109, 101, 116, 104, 111, 100, 46, 112, 97, 99, 107, 97, 103, 101 };
        // MethodServiceBytes = System.Text.Encoding.UTF8.GetBytes("grpc.method.service");
        private static readonly byte[] MethodServiceBytes = new byte[] { 103, 114, 112, 99, 46, 109, 101, 116, 104, 111, 100, 46, 115, 101, 114, 118, 105, 99, 101 };
        // StatusCodeBytes = System.Text.Encoding.UTF8.GetBytes("grpc.status.code");
        private static readonly byte[] StatusCodeBytes = new byte[] { 103, 114, 112, 99, 46, 115, 116, 97, 116, 117, 115, 46, 99, 111, 100, 101 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "grpc.method.kind" => MethodKind,
                "grpc.method.name" => MethodName,
                "grpc.method.path" => MethodPath,
                "grpc.method.package" => MethodPackage,
                "grpc.method.service" => MethodService,
                "grpc.status.code" => StatusCode,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "grpc.method.kind": 
                    MethodKind = value;
                    break;
                case "grpc.method.name": 
                    MethodName = value;
                    break;
                case "grpc.method.path": 
                    MethodPath = value;
                    break;
                case "grpc.method.package": 
                    MethodPackage = value;
                    break;
                case "grpc.method.service": 
                    MethodService = value;
                    break;
                case "grpc.status.code": 
                    StatusCode = value;
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

            if (MethodKind is not null)
            {
                processor.Process(new TagItem<string>("grpc.method.kind", MethodKind, MethodKindBytes));
            }

            if (MethodName is not null)
            {
                processor.Process(new TagItem<string>("grpc.method.name", MethodName, MethodNameBytes));
            }

            if (MethodPath is not null)
            {
                processor.Process(new TagItem<string>("grpc.method.path", MethodPath, MethodPathBytes));
            }

            if (MethodPackage is not null)
            {
                processor.Process(new TagItem<string>("grpc.method.package", MethodPackage, MethodPackageBytes));
            }

            if (MethodService is not null)
            {
                processor.Process(new TagItem<string>("grpc.method.service", MethodService, MethodServiceBytes));
            }

            if (StatusCode is not null)
            {
                processor.Process(new TagItem<string>("grpc.status.code", StatusCode, StatusCodeBytes));
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

            if (MethodKind is not null)
            {
                sb.Append("grpc.method.kind (tag):")
                  .Append(MethodKind)
                  .Append(',');
            }

            if (MethodName is not null)
            {
                sb.Append("grpc.method.name (tag):")
                  .Append(MethodName)
                  .Append(',');
            }

            if (MethodPath is not null)
            {
                sb.Append("grpc.method.path (tag):")
                  .Append(MethodPath)
                  .Append(',');
            }

            if (MethodPackage is not null)
            {
                sb.Append("grpc.method.package (tag):")
                  .Append(MethodPackage)
                  .Append(',');
            }

            if (MethodService is not null)
            {
                sb.Append("grpc.method.service (tag):")
                  .Append(MethodService)
                  .Append(',');
            }

            if (StatusCode is not null)
            {
                sb.Append("grpc.status.code (tag):")
                  .Append(StatusCode)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif