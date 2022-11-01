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
    partial class RabbitMQTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // CommandBytes = System.Text.Encoding.UTF8.GetBytes("amqp.command");
        private static readonly byte[] CommandBytes = new byte[] { 97, 109, 113, 112, 46, 99, 111, 109, 109, 97, 110, 100 };
        // DeliveryModeBytes = System.Text.Encoding.UTF8.GetBytes("amqp.delivery_mode");
        private static readonly byte[] DeliveryModeBytes = new byte[] { 97, 109, 113, 112, 46, 100, 101, 108, 105, 118, 101, 114, 121, 95, 109, 111, 100, 101 };
        // ExchangeBytes = System.Text.Encoding.UTF8.GetBytes("amqp.exchange");
        private static readonly byte[] ExchangeBytes = new byte[] { 97, 109, 113, 112, 46, 101, 120, 99, 104, 97, 110, 103, 101 };
        // RoutingKeyBytes = System.Text.Encoding.UTF8.GetBytes("amqp.routing_key");
        private static readonly byte[] RoutingKeyBytes = new byte[] { 97, 109, 113, 112, 46, 114, 111, 117, 116, 105, 110, 103, 95, 107, 101, 121 };
        // MessageSizeBytes = System.Text.Encoding.UTF8.GetBytes("message.size");
        private static readonly byte[] MessageSizeBytes = new byte[] { 109, 101, 115, 115, 97, 103, 101, 46, 115, 105, 122, 101 };
        // QueueBytes = System.Text.Encoding.UTF8.GetBytes("amqp.queue");
        private static readonly byte[] QueueBytes = new byte[] { 97, 109, 113, 112, 46, 113, 117, 101, 117, 101 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "amqp.command" => Command,
                "amqp.delivery_mode" => DeliveryMode,
                "amqp.exchange" => Exchange,
                "amqp.routing_key" => RoutingKey,
                "message.size" => MessageSize,
                "amqp.queue" => Queue,
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
                case "amqp.command": 
                    Command = value;
                    break;
                case "amqp.delivery_mode": 
                    DeliveryMode = value;
                    break;
                case "amqp.exchange": 
                    Exchange = value;
                    break;
                case "amqp.routing_key": 
                    RoutingKey = value;
                    break;
                case "message.size": 
                    MessageSize = value;
                    break;
                case "amqp.queue": 
                    Queue = value;
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

            if (Command is not null)
            {
                processor.Process(new TagItem<string>("amqp.command", Command, CommandBytes));
            }

            if (DeliveryMode is not null)
            {
                processor.Process(new TagItem<string>("amqp.delivery_mode", DeliveryMode, DeliveryModeBytes));
            }

            if (Exchange is not null)
            {
                processor.Process(new TagItem<string>("amqp.exchange", Exchange, ExchangeBytes));
            }

            if (RoutingKey is not null)
            {
                processor.Process(new TagItem<string>("amqp.routing_key", RoutingKey, RoutingKeyBytes));
            }

            if (MessageSize is not null)
            {
                processor.Process(new TagItem<string>("message.size", MessageSize, MessageSizeBytes));
            }

            if (Queue is not null)
            {
                processor.Process(new TagItem<string>("amqp.queue", Queue, QueueBytes));
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

            if (Command is not null)
            {
                sb.Append("amqp.command (tag):")
                  .Append(Command)
                  .Append(',');
            }

            if (DeliveryMode is not null)
            {
                sb.Append("amqp.delivery_mode (tag):")
                  .Append(DeliveryMode)
                  .Append(',');
            }

            if (Exchange is not null)
            {
                sb.Append("amqp.exchange (tag):")
                  .Append(Exchange)
                  .Append(',');
            }

            if (RoutingKey is not null)
            {
                sb.Append("amqp.routing_key (tag):")
                  .Append(RoutingKey)
                  .Append(',');
            }

            if (MessageSize is not null)
            {
                sb.Append("message.size (tag):")
                  .Append(MessageSize)
                  .Append(',');
            }

            if (Queue is not null)
            {
                sb.Append("amqp.queue (tag):")
                  .Append(Queue)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif