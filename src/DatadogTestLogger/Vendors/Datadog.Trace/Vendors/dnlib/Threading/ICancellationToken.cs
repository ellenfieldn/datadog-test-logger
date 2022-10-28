//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011,SYSLIB0032
// dnlib: See LICENSE.txt for more info

using System;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.Threading {
	/// <summary>
	/// Cancellation token interface
	/// </summary>
	internal interface ICancellationToken {
		/// <summary>
		/// Throws a <see cref="OperationCanceledException"/> if the operation should be canceled
		/// </summary>
		void ThrowIfCancellationRequested();
	}
}
