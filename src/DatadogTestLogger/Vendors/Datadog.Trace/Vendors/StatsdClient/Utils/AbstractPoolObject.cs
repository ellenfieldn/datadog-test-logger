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
using System.Diagnostics;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient.Utils
{
    internal abstract class AbstractPoolObject : IDisposable
    {
        private readonly IPool _pool;
        private bool _enqueue = false;

        public AbstractPoolObject(IPool pool)
        {
            _pool = pool;
        }

        ~AbstractPoolObject()
        {
            try
            {
                Dispose(false);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Reset()
        {
            _enqueue = false;
            DoReset();
        }

        protected abstract void DoReset();

        protected void Dispose(bool disposing)
        {
            if (!_enqueue)
            {
                _pool.Enqueue(this);
            }

            _enqueue = true;
        }
    }
}