//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;
using System.Threading;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Worker
{
    internal class Waiter : IWaiter
    {
        public void Wait(TimeSpan duration)
        {
            Thread.Sleep(duration);
        }
    }
}
