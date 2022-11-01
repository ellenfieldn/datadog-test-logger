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
    partial class MsmqTags
    {
        // CommandBytes = System.Text.Encoding.UTF8.GetBytes("msmq.command");
        private static readonly byte[] CommandBytes = new byte[] { 109, 115, 109, 113, 46, 99, 111, 109, 109, 97, 110, 100 };
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // InstrumentationNameBytes = System.Text.Encoding.UTF8.GetBytes("component");
        private static readonly byte[] InstrumentationNameBytes = new byte[] { 99, 111, 109, 112, 111, 110, 101, 110, 116 };
        // PathBytes = System.Text.Encoding.UTF8.GetBytes("msmq.queue.path");
        private static readonly byte[] PathBytes = new byte[] { 109, 115, 109, 113, 46, 113, 117, 101, 117, 101, 46, 112, 97, 116, 104 };
        // MessageWithTransactionBytes = System.Text.Encoding.UTF8.GetBytes("msmq.message.transactional");
        private static readonly byte[] MessageWithTransactionBytes = new byte[] { 109, 115, 109, 113, 46, 109, 101, 115, 115, 97, 103, 101, 46, 116, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 97, 108 };
        // IsTransactionalQueueBytes = System.Text.Encoding.UTF8.GetBytes("msmq.queue.transactional");
        private static readonly byte[] IsTransactionalQueueBytes = new byte[] { 109, 115, 109, 113, 46, 113, 117, 101, 117, 101, 46, 116, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 97, 108 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "msmq.command" => Command,
                "span.kind" => SpanKind,
                "component" => InstrumentationName,
                "msmq.queue.path" => Path,
                "msmq.message.transactional" => MessageWithTransaction,
                "msmq.queue.transactional" => IsTransactionalQueue,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "msmq.command": 
                    Command = value;
                    break;
                case "msmq.queue.path": 
                    Path = value;
                    break;
                case "msmq.message.transactional": 
                    MessageWithTransaction = value;
                    break;
                case "msmq.queue.transactional": 
                    IsTransactionalQueue = value;
                    break;
                default: 
                    base.SetTag(key, value);
                    break;
            }
        }

        public override void EnumerateTags<TProcessor>(ref TProcessor processor)
        {
            if (Command is not null)
            {
                processor.Process(new TagItem<string>("msmq.command", Command, CommandBytes));
            }

            if (SpanKind is not null)
            {
                processor.Process(new TagItem<string>("span.kind", SpanKind, SpanKindBytes));
            }

            if (InstrumentationName is not null)
            {
                processor.Process(new TagItem<string>("component", InstrumentationName, InstrumentationNameBytes));
            }

            if (Path is not null)
            {
                processor.Process(new TagItem<string>("msmq.queue.path", Path, PathBytes));
            }

            if (MessageWithTransaction is not null)
            {
                processor.Process(new TagItem<string>("msmq.message.transactional", MessageWithTransaction, MessageWithTransactionBytes));
            }

            if (IsTransactionalQueue is not null)
            {
                processor.Process(new TagItem<string>("msmq.queue.transactional", IsTransactionalQueue, IsTransactionalQueueBytes));
            }

            base.EnumerateTags(ref processor);
        }

        protected override void WriteAdditionalTags(System.Text.StringBuilder sb)
        {
            if (Command is not null)
            {
                sb.Append("msmq.command (tag):")
                  .Append(Command)
                  .Append(',');
            }

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

            if (Path is not null)
            {
                sb.Append("msmq.queue.path (tag):")
                  .Append(Path)
                  .Append(',');
            }

            if (MessageWithTransaction is not null)
            {
                sb.Append("msmq.message.transactional (tag):")
                  .Append(MessageWithTransaction)
                  .Append(',');
            }

            if (IsTransactionalQueue is not null)
            {
                sb.Append("msmq.queue.transactional (tag):")
                  .Append(IsTransactionalQueue)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif