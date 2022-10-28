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

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Pdb.Symbols {
	/// <summary>
	/// Async step info
	/// </summary>
	internal struct SymbolAsyncStepInfo {
		/// <summary>
		/// Yield offset
		/// </summary>
		public uint YieldOffset;

		/// <summary>
		/// Breakpoint offset
		/// </summary>
		public uint BreakpointOffset;

		/// <summary>
		/// Breakpoint method token
		/// </summary>
		public uint BreakpointMethod;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="yieldOffset">Yield offset</param>
		/// <param name="breakpointOffset">Breakpoint offset</param>
		/// <param name="breakpointMethod">Breakpoint method token</param>
		public SymbolAsyncStepInfo(uint yieldOffset, uint breakpointOffset, uint breakpointMethod) {
			YieldOffset = yieldOffset;
			BreakpointOffset = breakpointOffset;
			BreakpointMethod = breakpointMethod;
		}
	}
}
