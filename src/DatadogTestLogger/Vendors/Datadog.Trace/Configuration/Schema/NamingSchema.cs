//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="NamingSchema.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

using System.Collections.Generic;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Configuration.Schema
{
    internal class NamingSchema
    {
        public NamingSchema(SchemaVersion version, string defaultServiceName, IDictionary<string, string>? serviceNameMappings)
        {
            Version = version;
            Database = new DatabaseSchema(version, defaultServiceName, serviceNameMappings);
            Messaging = new MessagingSchema(version, defaultServiceName, serviceNameMappings);
        }

        // TODO: Temporary, we can probably delete this once we migrate all the code off MetadataSchemaVersion
        public SchemaVersion Version { get; }

        public DatabaseSchema Database { get; }

        public MessagingSchema Messaging { get; }
    }
}
