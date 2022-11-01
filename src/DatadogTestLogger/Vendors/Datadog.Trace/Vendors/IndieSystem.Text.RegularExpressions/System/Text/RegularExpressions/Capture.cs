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

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions
{
    /// <summary>
    /// Represents the results from a single subexpression capture. The object represents
    /// one substring for a single successful capture.
    /// </summary>
    internal class Capture
    {
        internal Capture(string? text, int index, int length)
        {
            Text = text;
            Index = index;
            Length = length;
        }

        /// <summary>Returns the position in the original string where the first character of captured substring was found.</summary>
        public int Index { get; private protected set; }

        /// <summary>Returns the length of the captured substring.</summary>
        public int Length { get; private protected set; }

        /// <summary>The original string</summary>
        internal string? Text { get; set; }

        /// <summary>Gets the captured substring from the input string.</summary>
        /// <value>The substring that is captured by the match.</value>
        public string Value => Text is string text ? text.Substring(Index, Length) : string.Empty;

        /// <summary>Gets the captured span from the input string.</summary>
        /// <value>The span that is captured by the match.</value>
        public ReadOnlySpan<char> ValueSpan => Text is string text ? text.AsSpan(Index, Length) : ReadOnlySpan<char>.Empty;

        /// <summary>Returns the substring that was matched.</summary>
        public override string ToString() => Value;

        /// <summary>The substring to the left of the capture</summary>
        internal ReadOnlyMemory<char> GetLeftSubstring() => Text is string text ? text.AsMemory(0, Index) : ReadOnlyMemory<char>.Empty;

        /// <summary>The substring to the right of the capture</summary>
        internal ReadOnlyMemory<char> GetRightSubstring() => Text is string text ? text.AsMemory(Index + Length, Text.Length - Index - Length) : ReadOnlyMemory<char>.Empty;
    }
}

#endif