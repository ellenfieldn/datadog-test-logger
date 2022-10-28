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
using System.Threading;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Pdb.Portable {
	static class ListCache<T> {
		static volatile List<T> cachedList;
		public static List<T> AllocList() => Interlocked.Exchange(ref cachedList, null) ?? new List<T>();
		public static void Free(ref List<T> list) {
			list.Clear();
			cachedList = list;
		}
		public static T[] FreeAndToArray(ref List<T> list) {
			var res = list.ToArray();
			Free(ref list);
			return res;
		}
	}
}
