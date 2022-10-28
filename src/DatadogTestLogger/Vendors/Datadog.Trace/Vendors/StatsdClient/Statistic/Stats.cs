//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Utils;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Statistic
{
    /// <summary>
    /// Stats stores the data for a metric or a service check or an event.
    /// The field `Metric`, `ServiceCheck` and `Event` are structures for performance reasons. These
    /// fields are embeded inside Stats and so do not require extra allocations.
    /// </summary>
    internal class Stats : AbstractPoolObject
    {
        // The next 3 fields are not properties because we want to take a reference on them to avoid a copy.
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Take a reference on struct")]
        public StatsMetric Metric;

        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Take a reference on struct")]
        public StatsServiceCheck ServiceCheck;

        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Take a reference on struct")]
        public StatsEvent Event;

        public Stats(IPool pool)
            : base(pool)
        {
        }

        public StatsKind Kind { get; set; }

        protected override void DoReset()
        {
            // Nothing
        }
    }
}