//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Copyright (c) 2008 - 2015 Jb Evain
// Copyright (c) 2008 - 2011 Novell, Inc.
//
// Licensed under the MIT/X11 license.
//

using System;

using MD = DatadogCollector.Vendors.Mono.Cecil.Metadata;

namespace DatadogCollector.Vendors.Mono.Cecil {

	internal sealed class PointerType : TypeSpecification {

		public override string Name {
			get { return base.Name + "*"; }
		}

		public override string FullName {
			get { return base.FullName + "*"; }
		}

		public override bool IsValueType {
			get { return false; }
			set { throw new InvalidOperationException (); }
		}

		public override bool IsPointer {
			get { return true; }
		}

		public PointerType (TypeReference type)
			: base (type)
		{
			Mixin.CheckType (type);
			this.etype = MD.ElementType.Ptr;
		}
	}
}
