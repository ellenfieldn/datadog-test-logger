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
using System.Runtime.Serialization;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Writer {
	/// <summary>
	/// Thrown when the module writer encounters an unrecoverable error
	/// </summary>
	[Serializable]
	internal class ModuleWriterException : Exception {
		/// <summary>
		/// Default constructor
		/// </summary>
		public ModuleWriterException() {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Error message</param>
		public ModuleWriterException(string message)
			: base(message) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Error message</param>
		/// <param name="innerException">Other exception</param>
		public ModuleWriterException(string message, Exception innerException)
			: base(message, innerException) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ModuleWriterException(SerializationInfo info, StreamingContext context)
			: base(info, context) {
		}
	}
}
