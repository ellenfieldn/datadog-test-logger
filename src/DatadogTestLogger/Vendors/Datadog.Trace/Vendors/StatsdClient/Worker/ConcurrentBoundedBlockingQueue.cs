//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
using System;
using System.Threading;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Worker
{
    /// <summary>
    /// ConcurrentBoundedBlockingQueue is the same as ConcurrentBoundedQueue but
    /// it waits for `waitTimeout` before dropping the value when the queue is full.
    /// </summary>
    internal class ConcurrentBoundedBlockingQueue<T> : ConcurrentBoundedQueue<T>
    {
        private readonly IManualResetEvent _queueIsFullEvent;
        private readonly TimeSpan _waitTimeout;

        public ConcurrentBoundedBlockingQueue(IManualResetEvent queueIsFullEvent, TimeSpan waitTimeout, int maxItemCount)
                : base(maxItemCount)
        {
            _queueIsFullEvent = queueIsFullEvent;
            _waitTimeout = waitTimeout;
            _queueIsFullEvent.Reset();
        }

        public override bool TryEnqueue(T value)
        {
            while (!base.TryEnqueue(value))
            {
                if (!_queueIsFullEvent.Wait(_waitTimeout))
                {
                    return false;
                }

                _queueIsFullEvent.Reset();
            }

            return true;
        }

        public override bool TryDequeue(out T value)
        {
            if (base.TryDequeue(out value))
            {
                _queueIsFullEvent.Set();
                return true;
            }

            value = default(T);
            return false;
        }
    }
}
