//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Statistic
{
    /// <summary>
    /// Store the data for a service check.
    /// </summary>
    internal struct StatsServiceCheck
    {
        public string Name { get; set; }

        public int Status { get; set; }

        public int? Timestamp { get; set; }

        public string Hostname { get; set; }

        public string ServiceCheckMessage { get; set; }

        public bool TruncateIfTooLong { get; set; }

        public string[] Tags { get; set; }

        public override bool Equals(object obj)
        {
            throw new NotSupportedException("The default implementation has performance issues.");
        }

        public override int GetHashCode()
        {
            throw new NotSupportedException("The default implementation has performance issues.");
        }
    }
}