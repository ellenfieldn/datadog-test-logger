//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011,SYSLIB0032
// dnlib: See LICENSE.txt for more info

using System;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet {
	/// <summary>
	/// Generic parameter flags. See CorHdr.h/CorGenericParamAttr
	/// </summary>
	[Flags]
	internal enum GenericParamAttributes : ushort {
		/// <summary/>
		VarianceMask			= 0x0003,
		/// <summary/>
		NonVariant				= 0x0000,
		/// <summary/>
		Covariant				= 0x0001,
		/// <summary/>
		Contravariant			= 0x0002,

		/// <summary/>
		SpecialConstraintMask	= 0x001C,
		/// <summary/>
		NoSpecialConstraint		= 0x0000,
		/// <summary>type argument must be a reference type</summary>
		ReferenceTypeConstraint = 0x0004,
		/// <summary>type argument must be a value type but not Nullable</summary>
		NotNullableValueTypeConstraint = 0x0008,
		/// <summary>type argument must have a public default constructor</summary>
		DefaultConstructorConstraint = 0x0010,
	}
}
