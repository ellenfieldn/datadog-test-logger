//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011,SYSLIB0032
// dnlib: See LICENSE.txt for more info

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Resources {
	/// <summary>
	/// User resource type
	/// </summary>
	internal sealed class UserResourceType {
		readonly string name;
		readonly ResourceTypeCode code;

		/// <summary>
		/// Full name including assembly of type
		/// </summary>
		public string Name => name;

		/// <summary>
		/// User type code
		/// </summary>
		public ResourceTypeCode Code => code;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">Full name including assembly of type</param>
		/// <param name="code">User type code</param>
		public UserResourceType(string name, ResourceTypeCode code) {
			this.name = name;
			this.code = code;
		}

		/// <inheritdoc/>
		public override string ToString() => $"{(int)code:X2} {name}";
	}
}
