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

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions
{
    /// <summary>
    /// Represents the results from a single regular expression match.
    /// </summary>
    /// <remarks>
    /// The <see cref="ValueMatch"/> type is immutable and has no public constructor. An instance of the <see cref="ValueMatch"/> struct is returned by the
    /// <see cref="Regex.ValueMatchEnumerator.Current"/> method when iterating over the results from calling <see cref="Regex.EnumerateMatches(ReadOnlySpan{char})"/>.
    /// </remarks>
    internal readonly ref struct ValueMatch
    {
        private readonly int _index;
        private readonly int _length;

        /// <summary>
        /// Crates an instance of the <see cref="ValueMatch"/> type based on the passed in <paramref name="index"/> and <paramref name="length"/>.
        /// </summary>
        /// <param name="index">The position in the original span where the first character of the captured sliced span is found.</param>
        /// <param name="length">The length of the captured sliced span.</param>
        internal ValueMatch(int index, int length)
        {
            _index = index;
            _length = length;
        }

        /// <summary>
        /// Gets the position in the original span where the first character of the captured sliced span is found.
        /// </summary>
        public int Index => _index;

        /// <summary>
        /// Gets the length of the captured sliced span.
        /// </summary>
        public int Length => _length;
    }
}

#endif