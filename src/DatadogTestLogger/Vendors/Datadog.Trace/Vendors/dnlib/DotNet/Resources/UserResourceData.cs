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

using System.IO;
using System.Runtime.Serialization;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.IO;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Resources {
	/// <summary>
	/// Base class of all user data
	/// </summary>
	internal abstract class UserResourceData : IResourceData {
		readonly UserResourceType type;

		/// <summary>
		/// Full name including assembly of type
		/// </summary>
		public string TypeName => type.Name;

		/// <summary>
		/// User type code
		/// </summary>
		public ResourceTypeCode Code => type.Code;

		/// <inheritdoc/>
		public FileOffset StartOffset { get; set; }

		/// <inheritdoc/>
		public FileOffset EndOffset { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type">User resource type</param>
		public UserResourceData(UserResourceType type) => this.type = type;

		/// <inheritdoc/>
		public abstract void WriteData(BinaryWriter writer, IFormatter formatter);
	}

	/// <summary>
	/// Binary data
	/// </summary>
	internal sealed class BinaryResourceData : UserResourceData {
		byte[] data;

		/// <summary>
		/// Gets the raw data
		/// </summary>
		public byte[] Data => data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type">User resource type</param>
		/// <param name="data">Raw serialized data</param>
		public BinaryResourceData(UserResourceType type, byte[] data)
			: base(type) => this.data = data;

		/// <inheritdoc/>
		public override void WriteData(BinaryWriter writer, IFormatter formatter) => writer.Write(data);

		/// <inheritdoc/>
		public override string ToString() => "Binary: Length: " + data.Length.ToString();
	}
}
