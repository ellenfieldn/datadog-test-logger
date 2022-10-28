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
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.IO;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.PE;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.dnlib.DotNet.Writer {
	/// <summary>
	/// Re-uses existing chunks to save space
	/// </summary>
	/// <typeparam name="T">Chunk type</typeparam>
	internal sealed class UniqueChunkList<T> : ChunkListBase<T> where T : class, IChunk {
		Dictionary<Elem, Elem> dict;

		/// <summary>
		/// Default constructor
		/// </summary>
		public UniqueChunkList()
			: this(EqualityComparer<T>.Default) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="chunkComparer">Compares the chunk type</param>
		public UniqueChunkList(IEqualityComparer<T> chunkComparer) {
			chunks = new List<Elem>();
			dict = new Dictionary<Elem, Elem>(new ElemEqualityComparer(chunkComparer));
		}

		/// <inheritdoc/>
		public override void SetOffset(FileOffset offset, RVA rva) {
			dict = null;
			base.SetOffset(offset, rva);
		}

		/// <summary>
		/// Adds a <see cref="IChunk"/> if not already present
		/// </summary>
		/// <param name="chunk">The chunk to add or <c>null</c> if none</param>
		/// <param name="alignment">Chunk alignment</param>
		/// <returns>The original input if it wasn't present, or the cached one</returns>
		public T Add(T chunk, uint alignment) {
			if (setOffsetCalled)
				throw new InvalidOperationException("SetOffset() has already been called");
			if (chunk is null)
				return null;
			var elem = new Elem(chunk, alignment);
			if (dict.TryGetValue(elem, out var other))
				return other.chunk;
			dict[elem] = elem;
			chunks.Add(elem);
			return elem.chunk;
		}
	}
}
