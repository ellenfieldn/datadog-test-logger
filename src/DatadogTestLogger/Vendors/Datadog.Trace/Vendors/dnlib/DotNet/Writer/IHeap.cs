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

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Writer {
	/// <summary>
	/// .NET Heap interface
	/// </summary>
	internal interface IHeap : IChunk {
		/// <summary>
		/// Gets the name of the heap
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Checks whether the heap is empty
		/// </summary>
		bool IsEmpty { get; }

		/// <summary>
		/// Called when the heap should be set to read-only mode
		/// </summary>
		void SetReadOnly();
	}
}
