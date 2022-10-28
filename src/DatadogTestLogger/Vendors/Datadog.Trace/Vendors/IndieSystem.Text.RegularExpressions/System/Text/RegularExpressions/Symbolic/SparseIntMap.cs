//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
#nullable enable
#if NETCOREAPP3_1_OR_GREATER
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions.Symbolic
{
    /// <summary>An insertion-ordered map that supports small int keys.</summary>
    /// <remarks>Uses a sparse array of the same size as the space of keys for efficient lookups.</remarks>
    internal sealed class SparseIntMap<T> where T : struct
    {
        private const int InitialCapacity = 16;

        private readonly List<KeyValuePair<int, T>> _dense = new();
        private int[] _sparse = new int[InitialCapacity];

        /// <summary>Remove all entries. Does not decrease capacity.</summary>
        public void Clear() => _dense.Clear();

        /// <summary>Number of entries in the map.</summary>
        public int Count => _dense.Count;

        /// <summary>Get the internal list of entries. Do not modify.</summary>
        public List<KeyValuePair<int, T>> Values => _dense;

        /// <summary>Find or add an entry matching the key.</summary>
        /// <param name="key">the key to find or add</param>
        /// <param name="index">will be set to the index of the matching entry</param>
        /// <returns>whether a new entry was added</returns>
        public bool Add(int key, out int index)
        {
            int[] sparse = _sparse;
            if ((uint)key < (uint)sparse.Length)
            {
                List<KeyValuePair<int, T>> dense = _dense;
                int idx = sparse[key];
                if (idx < dense.Count)
                {
                    int entryKey = dense[idx].Key;
                    Debug.Assert(entryKey < sparse.Length);
                    if (key == entryKey)
                    {
                        index = idx;
                        return false;
                    }
                }

                sparse[key] = index = _dense.Count;
                dense.Add(new KeyValuePair<int, T>(key, default));
                return true;
            }

            return GrowAndAdd(key, out index);
        }

        /// <summary>Find or add an entry matching a key and then set the value of the entry.</summary>
        public bool Add(int key, T value)
        {
            bool added = Add(key, out int index);
            Update(index, key, value);
            return added;
        }

        /// <summary>Set the value of the entry at the index.</summary>
        public void Update(int index, int key, T value)
        {
            Debug.Assert(0 <= index && index < _dense.Count);
            Debug.Assert(_dense[index].Key == key);
            _dense[index] = new KeyValuePair<int, T>(key, value);
        }

        private bool GrowAndAdd(int key, out int index)
        {
            int newLength = key + 1;
            Debug.Assert(newLength > _sparse.Length);

            // At least double the size to amortize memory allocations
            newLength = Math.Max(2 * _sparse.Length, newLength);
            Array.Resize(ref _sparse, newLength);

            _sparse[key] = index = _dense.Count;
            _dense.Add(new KeyValuePair<int, T>(key, default));
            return true;
        }
    }
}

#endif