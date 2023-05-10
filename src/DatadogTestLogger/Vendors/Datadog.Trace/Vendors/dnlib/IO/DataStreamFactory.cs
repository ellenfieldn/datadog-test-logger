//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011,SYSLIB0032
// dnlib: See LICENSE.txt for more info

using System;
using System.Diagnostics;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.PE;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.IO {
	/// <summary>
	/// Creates <see cref="DataStream"/>s
	/// </summary>
	internal static unsafe class DataStreamFactory {
		//TODO: There are other places that use pointers that also need to be updated
		static bool supportsUnalignedAccesses = CalculateSupportsUnalignedAccesses();

		static bool CalculateSupportsUnalignedAccesses() {
			var machine = ProcessorArchUtils.GetProcessCpuArchitecture();
			switch (machine) {
			case Machine.I386:
			case Machine.AMD64:
				return true;
			case Machine.ARMNT:
			case Machine.ARM64:
				return false;
			default:
				Debug.Fail($"Unknown CPU arch: {machine}");
				return true;
			}
		}

		/// <summary>
		/// Creates a <see cref="DataStream"/> that reads from native memory
		/// </summary>
		/// <param name="data">Pointer to data</param>
		/// <returns></returns>
		public static DataStream Create(byte* data) {
			if (data is null)
				throw new ArgumentNullException(nameof(data));
			if (supportsUnalignedAccesses)
				return new UnalignedNativeMemoryDataStream(data);
			return new AlignedNativeMemoryDataStream(data);
		}

		/// <summary>
		/// Creates a <see cref="DataStream"/> that reads from a byte array
		/// </summary>
		/// <param name="data">Data</param>
		/// <returns></returns>
		public static DataStream Create(byte[] data) {
			if (data is null)
				throw new ArgumentNullException(nameof(data));
			if (supportsUnalignedAccesses)
				return new UnalignedByteArrayDataStream(data);
			return new AlignedByteArrayDataStream(data);
		}
	}
}
