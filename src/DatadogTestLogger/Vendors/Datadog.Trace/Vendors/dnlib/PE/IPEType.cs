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

using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.IO;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.PE {
	/// <summary>
	/// Converts a <see cref="FileOffset"/> to/from an <see cref="RVA"/>
	/// </summary>
	interface IPEType {
		/// <summary>
		/// Converts a <see cref="FileOffset"/> to an <see cref="RVA"/>, returns 0 if out of range
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="offset">The file offset to convert</param>
		/// <returns>The RVA</returns>
		RVA ToRVA(PEInfo peInfo, FileOffset offset);

		/// <summary>
		/// Converts an <see cref="RVA"/> to a <see cref="FileOffset"/>, returns 0 if out of range
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="rva">The RVA to convert</param>
		/// <returns>The file offset</returns>
		FileOffset ToFileOffset(PEInfo peInfo, RVA rva);
	}
}
