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

using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.IO;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.PE {
	/// <summary>
	/// Interface for PE optional header classes
	/// </summary>
	internal interface IImageOptionalHeader : IFileSection {
		/// <summary>
		/// Returns the Magic field
		/// </summary>
		ushort Magic { get; }

		/// <summary>
		/// Returns the MajorLinkerVersion field
		/// </summary>
		byte MajorLinkerVersion { get; }

		/// <summary>
		/// Returns the MinorLinkerVersion field
		/// </summary>
		byte MinorLinkerVersion { get; }

		/// <summary>
		/// Returns the SizeOfCode field
		/// </summary>
		uint SizeOfCode { get; }

		/// <summary>
		/// Returns the SizeOfInitializedData field
		/// </summary>
		uint SizeOfInitializedData { get; }

		/// <summary>
		/// Returns the SizeOfUninitializedData field
		/// </summary>
		uint SizeOfUninitializedData { get; }

		/// <summary>
		/// Returns the AddressOfEntryPoint field
		/// </summary>
		RVA AddressOfEntryPoint { get; }

		/// <summary>
		/// Returns the BaseOfCode field
		/// </summary>
		RVA BaseOfCode { get; }

		/// <summary>
		/// Returns the BaseOfData field
		/// </summary>
		RVA BaseOfData { get; }

		/// <summary>
		/// Returns the ImageBase field
		/// </summary>
		ulong ImageBase { get; }

		/// <summary>
		/// Returns the SectionAlignment field
		/// </summary>
		uint SectionAlignment { get; }

		/// <summary>
		/// Returns the FileAlignment field
		/// </summary>
		uint FileAlignment { get; }

		/// <summary>
		/// Returns the MajorOperatingSystemVersion field
		/// </summary>
		ushort MajorOperatingSystemVersion { get; }

		/// <summary>
		/// Returns the MinorOperatingSystemVersion field
		/// </summary>
		ushort MinorOperatingSystemVersion { get; }

		/// <summary>
		/// Returns the MajorImageVersion field
		/// </summary>
		ushort MajorImageVersion { get; }

		/// <summary>
		/// Returns the MinorImageVersion field
		/// </summary>
		ushort MinorImageVersion { get; }

		/// <summary>
		/// Returns the MajorSubsystemVersion field
		/// </summary>
		ushort MajorSubsystemVersion { get; }

		/// <summary>
		/// Returns the MinorSubsystemVersion field
		/// </summary>
		ushort MinorSubsystemVersion { get; }

		/// <summary>
		/// Returns the Win32VersionValue field
		/// </summary>
		uint Win32VersionValue { get; }

		/// <summary>
		/// Returns the SizeOfImage field
		/// </summary>
		uint SizeOfImage { get; }

		/// <summary>
		/// Returns the SizeOfHeaders field
		/// </summary>
		uint SizeOfHeaders { get; }

		/// <summary>
		/// Returns the CheckSum field
		/// </summary>
		uint CheckSum { get; }

		/// <summary>
		/// Returns the Subsystem field
		/// </summary>
		Subsystem Subsystem { get; }

		/// <summary>
		/// Returns the DllCharacteristics field
		/// </summary>
		DllCharacteristics DllCharacteristics { get; }

		/// <summary>
		/// Returns the SizeOfStackReserve field
		/// </summary>
		ulong SizeOfStackReserve { get; }

		/// <summary>
		/// Returns the SizeOfStackCommit field
		/// </summary>
		ulong SizeOfStackCommit { get; }

		/// <summary>
		/// Returns the SizeOfHeapReserve field
		/// </summary>
		ulong SizeOfHeapReserve { get; }

		/// <summary>
		/// Returns the SizeOfHeapCommit field
		/// </summary>
		ulong SizeOfHeapCommit { get; }

		/// <summary>
		/// Returns the LoaderFlags field
		/// </summary>
		uint LoaderFlags { get; }

		/// <summary>
		/// Returns the NumberOfRvaAndSizes field
		/// </summary>
		uint NumberOfRvaAndSizes { get; }

		/// <summary>
		/// Returns the DataDirectories field. This array contains exactly 16 elements.
		/// </summary>
		ImageDataDirectory[] DataDirectories { get; }
	}
}
