//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;
using System.Threading;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient.Worker
{
    /// <summary>
    /// Simple wrapper arround ManualResetEventSlim.
    /// </summary>
    internal class ManualResetEventWrapper : IManualResetEvent
    {
        private readonly ManualResetEventSlim _manualResetEvent = new ManualResetEventSlim(false);

        public void Reset()
        {
            _manualResetEvent.Reset();
        }

        public void Set()
        {
            _manualResetEvent.Set();
        }

        public bool Wait(TimeSpan duration)
        {
            return _manualResetEvent.Wait(duration);
        }
    }
}