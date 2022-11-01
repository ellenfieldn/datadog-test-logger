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
using System.Collections.Generic;
using System.Diagnostics;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet;
using DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Emit;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.dnlib.Utils {
	class CollectionDebugView<TValue> {
		readonly ICollection<TValue> list;
		public CollectionDebugView(ICollection<TValue> list) => this.list = list ?? throw new ArgumentNullException(nameof(list));

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public TValue[] Items {
			get {
				var array = new TValue[list.Count];
				list.CopyTo(array, 0);
				return array;
			}
		}
	}

	class CollectionDebugView<TValue, TOther> : CollectionDebugView<TValue> {
		public CollectionDebugView(ICollection<TValue> list) : base(list) { }
	}

	sealed class LocalList_CollectionDebugView : CollectionDebugView<Local> {
		public LocalList_CollectionDebugView(LocalList list) : base(list) { }
	}

	sealed class ParameterList_CollectionDebugView : CollectionDebugView<Parameter> {
		public ParameterList_CollectionDebugView(ParameterList list) : base(list) { }
	}
}
