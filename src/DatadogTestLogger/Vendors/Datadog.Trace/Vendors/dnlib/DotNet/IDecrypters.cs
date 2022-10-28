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

using System.Collections.Generic;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.PE;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Emit;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet {
	/// <summary>
	/// Interface to decrypt methods
	/// </summary>
	internal interface IMethodDecrypter {
		/// <summary>
		/// Gets the method's body
		/// </summary>
		/// <param name="rid"><c>Method</c> rid</param>
		/// <param name="rva">The <see cref="RVA"/> found in the method's <c>Method</c> row</param>
		/// <param name="parameters">The method's parameters</param>
		/// <param name="gpContext">Generic parameter context</param>
		/// <param name="methodBody">Updated with the method's <see cref="MethodBody"/> if this
		/// method returns <c>true</c></param>
		/// <returns><c>true</c> if the method body was decrypted, <c>false</c> if the method isn't
		/// encrypted and the default <see cref="MethodDef"/> body reader code should be used.</returns>
		bool GetMethodBody(uint rid, RVA rva, IList<Parameter> parameters, GenericParamContext gpContext, out MethodBody methodBody);
	}

	/// <summary>
	/// Interface to decrypt strings
	/// </summary>
	internal interface IStringDecrypter {
		/// <summary>
		/// Reads a string
		/// </summary>
		/// <param name="token">String token</param>
		/// <returns>A string or <c>null</c> if we should read it from the #US heap</returns>
		string ReadUserString(uint token);
	}
}
