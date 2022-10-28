//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ProbeConfigurationComparer.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using Datadog.Trace.Vendors.Datadog.Trace.Debugger.Configurations.Models;

namespace Datadog.Trace.Vendors.Datadog.Trace.Debugger.Configurations
{
    internal class ProbeConfigurationComparer
    {
        public ProbeConfigurationComparer(
            ProbeConfiguration currentConfiguration,
            ProbeConfiguration incomingConfiguration)
        {
            var addedSnapshots = incomingConfiguration.SnapshotProbes.Where(ip => !currentConfiguration.SnapshotProbes.Contains(ip));
            var removedSnapshots = currentConfiguration.SnapshotProbes.Where(ip => !incomingConfiguration.SnapshotProbes.Contains(ip));

            var addedMetrics = incomingConfiguration.MetricProbes.Where(ip => !currentConfiguration.MetricProbes.Contains(ip));
            var removedMetrics = currentConfiguration.MetricProbes.Where(ip => !incomingConfiguration.MetricProbes.Contains(ip));

            AddedDefinitions = addedSnapshots.Cast<ProbeDefinition>().Concat(addedMetrics).ToList();
            RemovedDefinitions = removedSnapshots.Cast<ProbeDefinition>().Concat(removedMetrics).ToList();

            var isFilteredListChanged =
                (!currentConfiguration.AllowList?.Equals(incomingConfiguration.AllowList) ?? incomingConfiguration.AllowList != null)
             || (!currentConfiguration.DenyList?.Equals(incomingConfiguration.DenyList) ?? incomingConfiguration.DenyList != null);

            HasProbeRelatedChanges = AddedDefinitions.Any() || RemovedDefinitions.Any() || isFilteredListChanged;
            HasRateLimitChanged =
                (!currentConfiguration.Sampling?.Equals(incomingConfiguration.Sampling) ?? incomingConfiguration.Sampling != null)
             || HasProbeRelatedChanges;
        }

        public IReadOnlyList<ProbeDefinition> AddedDefinitions { get; }

        public IReadOnlyList<ProbeDefinition> RemovedDefinitions { get; }

        public bool HasProbeRelatedChanges { get; }

        public bool HasRateLimitChanged { get; }
    }
}
