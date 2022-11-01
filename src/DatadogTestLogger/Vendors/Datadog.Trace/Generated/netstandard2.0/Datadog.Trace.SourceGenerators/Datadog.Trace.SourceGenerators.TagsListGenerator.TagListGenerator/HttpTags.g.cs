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

namespace DatadogTestLogger.Vendors.Datadog.Trace.Tagging
{
    partial class HttpTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // HttpMethodBytes = System.Text.Encoding.UTF8.GetBytes("http.method");
        private static readonly byte[] HttpMethodBytes = new byte[] { 104, 116, 116, 112, 46, 109, 101, 116, 104, 111, 100 };
        // HttpUrlBytes = System.Text.Encoding.UTF8.GetBytes("http.url");
        private static readonly byte[] HttpUrlBytes = new byte[] { 104, 116, 116, 112, 46, 117, 114, 108 };
        // HttpClientHandlerTypeBytes = System.Text.Encoding.UTF8.GetBytes("http-client-handler-type");
        private static readonly byte[] HttpClientHandlerTypeBytes = new byte[] { 104, 116, 116, 112, 45, 99, 108, 105, 101, 110, 116, 45, 104, 97, 110, 100, 108, 101, 114, 45, 116, 121, 112, 101 };
        // HttpStatusCodeBytes = System.Text.Encoding.UTF8.GetBytes("http.status_code");
        private static readonly byte[] HttpStatusCodeBytes = new byte[] { 104, 116, 116, 112, 46, 115, 116, 97, 116, 117, 115, 95, 99, 111, 100, 101 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "http.method" => HttpMethod,
                "http.url" => HttpUrl,
                "http-client-handler-type" => HttpClientHandlerType,
                "http.status_code" => HttpStatusCode,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "component": 
                    InstrumentationName = value;
                    break;
                case "http.method": 
                    HttpMethod = value;
                    break;
                case "http.url": 
                    HttpUrl = value;
                    break;
                case "http-client-handler-type": 
                    HttpClientHandlerType = value;
                    break;
                case "http.status_code": 
                    HttpStatusCode = value;
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

            if (HttpMethod is not null)
            {
                processor.Process(new TagItem<string>("http.method", HttpMethod, HttpMethodBytes));
            }

            if (HttpUrl is not null)
            {
                processor.Process(new TagItem<string>("http.url", HttpUrl, HttpUrlBytes));
            }

            if (HttpClientHandlerType is not null)
            {
                processor.Process(new TagItem<string>("http-client-handler-type", HttpClientHandlerType, HttpClientHandlerTypeBytes));
            }

            if (HttpStatusCode is not null)
            {
                processor.Process(new TagItem<string>("http.status_code", HttpStatusCode, HttpStatusCodeBytes));
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

            if (HttpMethod is not null)
            {
                sb.Append("http.method (tag):")
                  .Append(HttpMethod)
                  .Append(',');
            }

            if (HttpUrl is not null)
            {
                sb.Append("http.url (tag):")
                  .Append(HttpUrl)
                  .Append(',');
            }

            if (HttpClientHandlerType is not null)
            {
                sb.Append("http-client-handler-type (tag):")
                  .Append(HttpClientHandlerType)
                  .Append(',');
            }

            if (HttpStatusCode is not null)
            {
                sb.Append("http.status_code (tag):")
                  .Append(HttpStatusCode)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif