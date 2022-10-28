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
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.PE;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Writer {
	/// <summary>
	/// Import address table chunk
	/// </summary>
	internal sealed class ImportAddressTable : IChunk {
		readonly bool is64bit;
		FileOffset offset;
		RVA rva;

		/// <summary>
		/// Gets/sets the <see cref="ImportDirectory"/>
		/// </summary>
		public ImportDirectory ImportDirectory { get; set; }

		/// <inheritdoc/>
		public FileOffset FileOffset => offset;

		/// <inheritdoc/>
		public RVA RVA => rva;

		internal bool Enable { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="is64bit">true if it's a 64-bit PE file, false if it's a 32-bit PE file</param>
		public ImportAddressTable(bool is64bit) => this.is64bit = is64bit;

		/// <inheritdoc/>
		public void SetOffset(FileOffset offset, RVA rva) {
			this.offset = offset;
			this.rva = rva;
		}

		/// <inheritdoc/>
		public uint GetFileLength() {
			if (!Enable)
				return 0;
			return is64bit ? 16U : 8;
		}

		/// <inheritdoc/>
		public uint GetVirtualSize() => GetFileLength();

		/// <inheritdoc/>
		public void WriteTo(DataWriter writer) {
			if (!Enable)
				return;
			if (is64bit) {
				writer.WriteUInt64((ulong)(uint)ImportDirectory.CorXxxMainRVA);
				writer.WriteUInt64(0);
			}
			else {
				writer.WriteUInt32((uint)ImportDirectory.CorXxxMainRVA);
				writer.WriteInt32(0);
			}
		}
	}
}
