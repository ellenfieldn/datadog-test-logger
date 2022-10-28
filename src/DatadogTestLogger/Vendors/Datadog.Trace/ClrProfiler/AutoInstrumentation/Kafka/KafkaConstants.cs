//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="KafkaConstants.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Datadog.Trace.Vendors.Datadog.Trace.Configuration;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler.AutoInstrumentation.Kafka
{
    internal static class KafkaConstants
    {
        internal const string IntegrationName = nameof(Configuration.IntegrationId.Kafka);
        internal const string ConsumeOperationName = "kafka.consume";
        internal const string ProduceOperationName = "kafka.produce";
        internal const string TopicPartitionTypeName = "Confluent.Kafka.TopicPartition";
        internal const string MessageTypeName = "Confluent.Kafka.Message`2[!0,!1]";
        internal const string ConsumeResultTypeName = "Confluent.Kafka.ConsumeResult`2[!0,!1]";
        internal const string ActionOfDeliveryReportTypeName = "System.Action`1[Confluent.Kafka.DeliveryReport`2[!0,!1]]";
        internal const string TaskDeliveryReportTypeName = "System.Threading.Tasks.Task`1[Confluent.Kafka.DeliveryReport`2[!0,!1]]";
        internal const string ServiceName = "kafka";
        internal const IntegrationId IntegrationId = Configuration.IntegrationId.Kafka;
    }
}
