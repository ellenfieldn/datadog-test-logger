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

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions.Symbolic
{
    internal readonly struct SymbolicMatch
    {
        /// <summary>Indicates failure to find a match.</summary>
        internal static SymbolicMatch NoMatch => new SymbolicMatch(-1, -1);

        /// <summary>Indicates a match was found but without meaningful details about where.</summary>
        internal static SymbolicMatch MatchExists => new SymbolicMatch(0, 0);

        public SymbolicMatch(int index, int length, int[]? captureStarts = null, int[]? captureEnds = null)
        {
            Index = index;
            Length = length;
            CaptureStarts = captureStarts;
            CaptureEnds = captureEnds;
        }

        public int Index { get; }

        public int Length { get; }

        public bool Success => Index >= 0;

        /// <summary>
        /// Array of capture start indices for each capture group. Each is a valid index into the input if the group
        /// was captured, or -1 otherwise.
        /// </summary>
        public readonly int[]? CaptureStarts { get; }

        /// <summary>
        /// Array of capture end indices for each capture group. Each is a valid index into the input and greater than
        /// the corresponding start position if the group was captured, or -1 otherwise.
        /// </summary>
        public readonly int[]? CaptureEnds { get; }
    }
}

#endif