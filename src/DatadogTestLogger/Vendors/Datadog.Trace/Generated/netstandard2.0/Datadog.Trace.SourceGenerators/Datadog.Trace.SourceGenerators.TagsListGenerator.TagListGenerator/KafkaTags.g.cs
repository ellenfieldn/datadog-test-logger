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
    partial class KafkaTags
    {
        // MessageQueueTimeMsBytes = System.Text.Encoding.UTF8.GetBytes("message.queue_time_ms");
        private static readonly byte[] MessageQueueTimeMsBytes = new byte[] { 109, 101, 115, 115, 97, 103, 101, 46, 113, 117, 101, 117, 101, 95, 116, 105, 109, 101, 95, 109, 115 };
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // PartitionBytes = System.Text.Encoding.UTF8.GetBytes("kafka.partition");
        private static readonly byte[] PartitionBytes = new byte[] { 107, 97, 102, 107, 97, 46, 112, 97, 114, 116, 105, 116, 105, 111, 110 };
        // OffsetBytes = System.Text.Encoding.UTF8.GetBytes("kafka.offset");
        private static readonly byte[] OffsetBytes = new byte[] { 107, 97, 102, 107, 97, 46, 111, 102, 102, 115, 101, 116 };
        // TombstoneBytes = System.Text.Encoding.UTF8.GetBytes("kafka.tombstone");
        private static readonly byte[] TombstoneBytes = new byte[] { 107, 97, 102, 107, 97, 46, 116, 111, 109, 98, 115, 116, 111, 110, 101 };
        // ConsumerGroupBytes = System.Text.Encoding.UTF8.GetBytes("kafka.group");
        private static readonly byte[] ConsumerGroupBytes = new byte[] { 107, 97, 102, 107, 97, 46, 103, 114, 111, 117, 112 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "kafka.partition" => Partition,
                "kafka.offset" => Offset,
                "kafka.tombstone" => Tombstone,
                "kafka.group" => ConsumerGroup,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "kafka.partition": 
                    Partition = value;
                    break;
                case "kafka.offset": 
                    Offset = value;
                    break;
                case "kafka.tombstone": 
                    Tombstone = value;
                    break;
                case "kafka.group": 
                    ConsumerGroup = value;
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

            if (Partition is not null)
            {
                processor.Process(new TagItem<string>("kafka.partition", Partition, PartitionBytes));
            }

            if (Offset is not null)
            {
                processor.Process(new TagItem<string>("kafka.offset", Offset, OffsetBytes));
            }

            if (Tombstone is not null)
            {
                processor.Process(new TagItem<string>("kafka.tombstone", Tombstone, TombstoneBytes));
            }

            if (ConsumerGroup is not null)
            {
                processor.Process(new TagItem<string>("kafka.group", ConsumerGroup, ConsumerGroupBytes));
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

            if (Partition is not null)
            {
                sb.Append("kafka.partition (tag):")
                  .Append(Partition)
                  .Append(',');
            }

            if (Offset is not null)
            {
                sb.Append("kafka.offset (tag):")
                  .Append(Offset)
                  .Append(',');
            }

            if (Tombstone is not null)
            {
                sb.Append("kafka.tombstone (tag):")
                  .Append(Tombstone)
                  .Append(',');
            }

            if (ConsumerGroup is not null)
            {
                sb.Append("kafka.group (tag):")
                  .Append(ConsumerGroup)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
        public override double? GetMetric(string key)
        {
            return key switch
            {
                "message.queue_time_ms" => MessageQueueTimeMs,
                _ => base.GetMetric(key),
            };
        }

        public override void SetMetric(string key, double? value)
        {
            switch(key)
            {
                case "message.queue_time_ms": 
                    MessageQueueTimeMs = value;
                    break;
                default: 
                    base.SetMetric(key, value);
                    break;
            }
        }

        public override void EnumerateMetrics<TProcessor>(ref TProcessor processor)
        {
            if (MessageQueueTimeMs is not null)
            {
                processor.Process(new TagItem<double>("message.queue_time_ms", MessageQueueTimeMs.Value, MessageQueueTimeMsBytes));
            }

            base.EnumerateMetrics(ref processor);
        }

        protected override void WriteAdditionalMetrics(System.Text.StringBuilder sb)
        {
            if (MessageQueueTimeMs is not null)
            {
                sb.Append("message.queue_time_ms (metric):")
                  .Append(MessageQueueTimeMs.Value)
                  .Append(',');
            }

            base.WriteAdditionalMetrics(sb);
        }
    }
}

#endif