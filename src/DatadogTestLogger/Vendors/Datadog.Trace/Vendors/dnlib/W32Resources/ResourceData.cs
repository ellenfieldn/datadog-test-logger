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
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.IO;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.W32Resources {
	/// <summary>
	/// A resource blob
	/// </summary>
	internal sealed class ResourceData : ResourceDirectoryEntry {
		readonly DataReaderFactory dataReaderFactory;
		readonly uint resourceStartOffset;
		readonly uint resourceLength;

		uint codePage;
		uint reserved;

		/// <summary>
		/// Gets the data reader
		/// </summary>
		/// <returns></returns>
		public DataReader CreateReader() => dataReaderFactory.CreateReader(resourceStartOffset, resourceLength);

		/// <summary>
		/// Gets/sets the code page
		/// </summary>
		public uint CodePage {
			get => codePage;
			set => codePage = value;
		}

		/// <summary>
		/// Gets/sets the reserved field
		/// </summary>
		public uint Reserved {
			get => reserved;
			set => reserved = value;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">Name</param>
		public ResourceData(ResourceName name)
			: this(name, ByteArrayDataReaderFactory.Create(Array2.Empty<byte>(), filename: null), 0, 0) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dataReaderFactory">Data reader factory</param>
		/// <param name="offset">Offset of resource data</param>
		/// <param name="length">Length of resource data</param>
		/// <param name="name">Name</param>
		public ResourceData(ResourceName name, DataReaderFactory dataReaderFactory, uint offset, uint length)
			: this(name, dataReaderFactory, offset, length, 0, 0) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dataReaderFactory">Data reader factory</param>
		/// <param name="offset">Offset of resource data</param>
		/// <param name="length">Length of resource data</param>
		/// <param name="name">Name</param>
		/// <param name="codePage">Code page</param>
		/// <param name="reserved">Reserved value</param>
		public ResourceData(ResourceName name, DataReaderFactory dataReaderFactory, uint offset, uint length, uint codePage, uint reserved)
			: base(name) {
			this.dataReaderFactory = dataReaderFactory ?? throw new ArgumentNullException(nameof(dataReaderFactory));
			resourceStartOffset = offset;
			resourceLength = length;
			this.codePage = codePage;
			this.reserved = reserved;
		}
	}
}
