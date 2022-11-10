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

namespace DatadogTestLogger.Vendors.Datadog.Trace.ServiceFabric
{
    partial class ServiceRemotingTags
    {
        // SpanKindBytes = System.Text.Encoding.UTF8.GetBytes("span.kind");
        private static readonly byte[] SpanKindBytes = new byte[] { 115, 112, 97, 110, 46, 107, 105, 110, 100 };
        // ApplicationIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.application-id");
        private static readonly byte[] ApplicationIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 97, 112, 112, 108, 105, 99, 97, 116, 105, 111, 110, 45, 105, 100 };
        // ApplicationNameBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.application-name");
        private static readonly byte[] ApplicationNameBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 97, 112, 112, 108, 105, 99, 97, 116, 105, 111, 110, 45, 110, 97, 109, 101 };
        // PartitionIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.partition-id");
        private static readonly byte[] PartitionIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 112, 97, 114, 116, 105, 116, 105, 111, 110, 45, 105, 100 };
        // NodeIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.node-id");
        private static readonly byte[] NodeIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 110, 111, 100, 101, 45, 105, 100 };
        // NodeNameBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.node-name");
        private static readonly byte[] NodeNameBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 110, 111, 100, 101, 45, 110, 97, 109, 101 };
        // ServiceNameBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-name");
        private static readonly byte[] ServiceNameBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 110, 97, 109, 101 };
        // RemotingUriBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-remoting.uri");
        private static readonly byte[] RemotingUriBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 114, 101, 109, 111, 116, 105, 110, 103, 46, 117, 114, 105 };
        // RemotingMethodNameBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-remoting.method-name");
        private static readonly byte[] RemotingMethodNameBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 114, 101, 109, 111, 116, 105, 110, 103, 46, 109, 101, 116, 104, 111, 100, 45, 110, 97, 109, 101 };
        // RemotingMethodIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-remoting.method-id");
        private static readonly byte[] RemotingMethodIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 114, 101, 109, 111, 116, 105, 110, 103, 46, 109, 101, 116, 104, 111, 100, 45, 105, 100 };
        // RemotingInterfaceIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-remoting.interface-id");
        private static readonly byte[] RemotingInterfaceIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 114, 101, 109, 111, 116, 105, 110, 103, 46, 105, 110, 116, 101, 114, 102, 97, 99, 101, 45, 105, 100 };
        // RemotingInvocationIdBytes = System.Text.Encoding.UTF8.GetBytes("service-fabric.service-remoting.invocation-id");
        private static readonly byte[] RemotingInvocationIdBytes = new byte[] { 115, 101, 114, 118, 105, 99, 101, 45, 102, 97, 98, 114, 105, 99, 46, 115, 101, 114, 118, 105, 99, 101, 45, 114, 101, 109, 111, 116, 105, 110, 103, 46, 105, 110, 118, 111, 99, 97, 116, 105, 111, 110, 45, 105, 100 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "span.kind" => SpanKind,
                "service-fabric.application-id" => ApplicationId,
                "service-fabric.application-name" => ApplicationName,
                "service-fabric.partition-id" => PartitionId,
                "service-fabric.node-id" => NodeId,
                "service-fabric.node-name" => NodeName,
                "service-fabric.service-name" => ServiceName,
                "service-fabric.service-remoting.uri" => RemotingUri,
                "service-fabric.service-remoting.method-name" => RemotingMethodName,
                "service-fabric.service-remoting.method-id" => RemotingMethodId,
                "service-fabric.service-remoting.interface-id" => RemotingInterfaceId,
                "service-fabric.service-remoting.invocation-id" => RemotingInvocationId,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "service-fabric.application-id": 
                    ApplicationId = value;
                    break;
                case "service-fabric.application-name": 
                    ApplicationName = value;
                    break;
                case "service-fabric.partition-id": 
                    PartitionId = value;
                    break;
                case "service-fabric.node-id": 
                    NodeId = value;
                    break;
                case "service-fabric.node-name": 
                    NodeName = value;
                    break;
                case "service-fabric.service-name": 
                    ServiceName = value;
                    break;
                case "service-fabric.service-remoting.uri": 
                    RemotingUri = value;
                    break;
                case "service-fabric.service-remoting.method-name": 
                    RemotingMethodName = value;
                    break;
                case "service-fabric.service-remoting.method-id": 
                    RemotingMethodId = value;
                    break;
                case "service-fabric.service-remoting.interface-id": 
                    RemotingInterfaceId = value;
                    break;
                case "service-fabric.service-remoting.invocation-id": 
                    RemotingInvocationId = value;
                    break;
                case "span.kind": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(ServiceRemotingTags));
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

            if (ApplicationId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.application-id", ApplicationId, ApplicationIdBytes));
            }

            if (ApplicationName is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.application-name", ApplicationName, ApplicationNameBytes));
            }

            if (PartitionId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.partition-id", PartitionId, PartitionIdBytes));
            }

            if (NodeId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.node-id", NodeId, NodeIdBytes));
            }

            if (NodeName is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.node-name", NodeName, NodeNameBytes));
            }

            if (ServiceName is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-name", ServiceName, ServiceNameBytes));
            }

            if (RemotingUri is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-remoting.uri", RemotingUri, RemotingUriBytes));
            }

            if (RemotingMethodName is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-remoting.method-name", RemotingMethodName, RemotingMethodNameBytes));
            }

            if (RemotingMethodId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-remoting.method-id", RemotingMethodId, RemotingMethodIdBytes));
            }

            if (RemotingInterfaceId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-remoting.interface-id", RemotingInterfaceId, RemotingInterfaceIdBytes));
            }

            if (RemotingInvocationId is not null)
            {
                processor.Process(new TagItem<string>("service-fabric.service-remoting.invocation-id", RemotingInvocationId, RemotingInvocationIdBytes));
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

            if (ApplicationId is not null)
            {
                sb.Append("service-fabric.application-id (tag):")
                  .Append(ApplicationId)
                  .Append(',');
            }

            if (ApplicationName is not null)
            {
                sb.Append("service-fabric.application-name (tag):")
                  .Append(ApplicationName)
                  .Append(',');
            }

            if (PartitionId is not null)
            {
                sb.Append("service-fabric.partition-id (tag):")
                  .Append(PartitionId)
                  .Append(',');
            }

            if (NodeId is not null)
            {
                sb.Append("service-fabric.node-id (tag):")
                  .Append(NodeId)
                  .Append(',');
            }

            if (NodeName is not null)
            {
                sb.Append("service-fabric.node-name (tag):")
                  .Append(NodeName)
                  .Append(',');
            }

            if (ServiceName is not null)
            {
                sb.Append("service-fabric.service-name (tag):")
                  .Append(ServiceName)
                  .Append(',');
            }

            if (RemotingUri is not null)
            {
                sb.Append("service-fabric.service-remoting.uri (tag):")
                  .Append(RemotingUri)
                  .Append(',');
            }

            if (RemotingMethodName is not null)
            {
                sb.Append("service-fabric.service-remoting.method-name (tag):")
                  .Append(RemotingMethodName)
                  .Append(',');
            }

            if (RemotingMethodId is not null)
            {
                sb.Append("service-fabric.service-remoting.method-id (tag):")
                  .Append(RemotingMethodId)
                  .Append(',');
            }

            if (RemotingInterfaceId is not null)
            {
                sb.Append("service-fabric.service-remoting.interface-id (tag):")
                  .Append(RemotingInterfaceId)
                  .Append(',');
            }

            if (RemotingInvocationId is not null)
            {
                sb.Append("service-fabric.service-remoting.invocation-id (tag):")
                  .Append(RemotingInvocationId)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

#endif