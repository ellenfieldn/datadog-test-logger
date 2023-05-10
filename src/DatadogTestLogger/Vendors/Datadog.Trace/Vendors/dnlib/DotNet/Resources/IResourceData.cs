//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011,SYSLIB0032
// dnlib: See LICENSE.txt for more info

using System.IO;
using System.Runtime.Serialization;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.IO;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Resources {
	/// <summary>
	/// Implemented by all resource data
	/// </summary>
	internal interface IResourceData : IFileSection {
		/// <summary>
		/// Gets the type of data
		/// </summary>
		ResourceTypeCode Code { get; }

		/// <summary>
		/// Start offset of the section in the file
		/// </summary>
		new FileOffset StartOffset { get; set; }

		/// <summary>
		/// End offset of the section in the file. This is one byte after the last
		/// valid offset in the section.
		/// </summary>
		new FileOffset EndOffset { get; set; }

		/// <summary>
		/// Writes the data
		/// </summary>
		/// <param name="writer">Writer</param>
		/// <param name="formatter">Formatter if needed by implementer</param>
		void WriteData(BinaryWriter writer, IFormatter formatter);
	}
}
