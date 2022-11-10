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
    partial class AwsSqsTags
    {
        // QueueNameBytes = System.Text.Encoding.UTF8.GetBytes("aws.queue.name");
        private static readonly byte[] QueueNameBytes = new byte[] { 97, 119, 115, 46, 113, 117, 101, 117, 101, 46, 110, 97, 109, 101 };
        // QueueUrlBytes = System.Text.Encoding.UTF8.GetBytes("aws.queue.url");
        private static readonly byte[] QueueUrlBytes = new byte[] { 97, 119, 115, 46, 113, 117, 101, 117, 101, 46, 117, 114, 108 };
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "aws.queue.name" => QueueName,
                "aws.queue.url" => QueueUrl,
                "span.kind" => SpanKind,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "aws.queue.name": 
                    QueueName = value;
                    break;
                case "aws.queue.url": 
                    QueueUrl = value;
                    break;
                case "span.kind": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(AwsSqsTags));
                    break;
                default: 
                    base.SetTag(key, value);
                    break;
            }
        }

        public override void EnumerateTags<TProcessor>(ref TProcessor processor)
        {
            if (QueueName is not null)
            {
                processor.Process(new TagItem<string>("aws.queue.name", QueueName, QueueNameBytes));
            }

            if (QueueUrl is not null)
            {
                processor.Process(new TagItem<string>("aws.queue.url", QueueUrl, QueueUrlBytes));
            }

            if (SpanKind is not null)
            {
                processor.Process(new TagItem<string>("span.kind", SpanKind, SpanKindBytes));
            }

            base.EnumerateTags(ref processor);
        }

        protected override void WriteAdditionalTags(System.Text.StringBuilder sb)
        {
            if (QueueName is not null)
            {
                sb.Append("aws.queue.name (tag):")
                  .Append(QueueName)
                  .Append(',');
            }

            if (QueueUrl is not null)
            {
                sb.Append("aws.queue.url (tag):")
                  .Append(QueueUrl)
                  .Append(',');
            }

            if (SpanKind is not null)
            {
                sb.Append("span.kind (tag):")
                  .Append(SpanKind)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif