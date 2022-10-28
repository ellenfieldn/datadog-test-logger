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
using System.Diagnostics;
using System.Globalization;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions.Symbolic
{
    /// <summary><see cref="RegexRunnerFactory"/> for symbolic regexes.</summary>
    internal sealed class SymbolicRegexRunnerFactory : RegexRunnerFactory
    {
        /// <summary>A SymbolicRegexMatcher of either ulong or <see cref="BitVector"/> depending on the number of minterms.</summary>
        internal readonly SymbolicRegexMatcher _matcher;

        /// <summary>Initializes the factory.</summary>
        public SymbolicRegexRunnerFactory(RegexTree regexTree, RegexOptions options, TimeSpan matchTimeout)
        {
            Debug.Assert((options & (RegexOptions.RightToLeft | RegexOptions.ECMAScript)) == 0);

            var charSetSolver = new CharSetSolver();
            var bddBuilder = new SymbolicRegexBuilder<BDD>(charSetSolver, charSetSolver);
            var converter = new RegexNodeConverter(bddBuilder, regexTree.CaptureNumberSparseMapping);

            SymbolicRegexNode<BDD> rootNode = converter.ConvertToSymbolicRegexNode(regexTree.Root);

            // Determine if the root node is supported for safe handling
            int threshold = SymbolicRegexThresholds.GetSymbolicRegexSafeSizeThreshold();
            Debug.Assert(threshold > 0);

            // Skip the threshold check if the threshold equals int.MaxValue
            if (threshold != int.MaxValue)
            {
                int size = rootNode.EstimateNfaSize();
                if (size > threshold)
                {
                    throw new NotSupportedException(SR.Format(SR.NotSupported_NonBacktrackingUnsafeSize, size, threshold));
                }
            }

            rootNode = rootNode.AddFixedLengthMarkers(bddBuilder);
            BDD[] minterms = rootNode.ComputeMinterms(bddBuilder);

            _matcher = minterms.Length > 64 ?
                SymbolicRegexMatcher<BitVector>.Create(regexTree.CaptureCount, regexTree.FindOptimizations, bddBuilder, rootNode, new BitVectorSolver(minterms, charSetSolver), matchTimeout) :
                SymbolicRegexMatcher<ulong>.Create(regexTree.CaptureCount, regexTree.FindOptimizations, bddBuilder, rootNode, new UInt64Solver(minterms, charSetSolver), matchTimeout);
        }

        /// <summary>Creates a <see cref="RegexRunner"/> object.</summary>
        protected internal override RegexRunner CreateInstance() => _matcher is SymbolicRegexMatcher<ulong> srmUInt64 ?
            new Runner<ulong>(srmUInt64) :
            new Runner<BitVector>((SymbolicRegexMatcher<BitVector>)_matcher);

        /// <summary>Runner type produced by this factory.</summary>
        /// <remarks>
        /// The wrapped <see cref="SymbolicRegexMatcher"/> is itself thread-safe and can be shared across
        /// all runner instances, but the runner itself has state (e.g. for captures, positions, etc.)
        /// and must not be shared between concurrent uses.
        /// </remarks>
        private sealed class Runner<TSet> : RegexRunner where TSet : IComparable<TSet>, IEquatable<TSet>
        {
            /// <summary>The matching engine.</summary>
            /// <remarks>The matcher is stateless and may be shared by any number of threads executing concurrently.</remarks>
            private readonly SymbolicRegexMatcher<TSet> _matcher;
            /// <summary>Runner-specific data to pass to the matching engine.</summary>
            /// <remarks>This state is per runner and is thus only used by one thread at a time.</remarks>
            private readonly SymbolicRegexMatcher<TSet>.PerThreadData _perThreadData;

            internal Runner(SymbolicRegexMatcher<TSet> matcher)
            {
                _matcher = matcher;
                _perThreadData = matcher.CreatePerThreadData();
            }

            protected internal override void Scan(ReadOnlySpan<char> text)
            {
                // Perform the match.
                SymbolicMatch pos = _matcher.FindMatch(_mode, text, runtextpos, _perThreadData);

                // Transfer the result back to the RegexRunner state.
                if (pos.Success)
                {
                    // If we successfully matched, capture the match, and then jump the current position to the end of the match.
                    int start = pos.Index;
                    int end = start + pos.Length;
                    if (_mode == RegexRunnerMode.FullMatchRequired && pos.CaptureStarts != null)
                    {
                        Debug.Assert(pos.CaptureEnds != null);
                        Debug.Assert(pos.CaptureStarts.Length == pos.CaptureEnds.Length);
                        for (int cap = 0; cap < pos.CaptureStarts.Length; ++cap)
                        {
                            if (pos.CaptureStarts[cap] >= 0)
                            {
                                Debug.Assert(pos.CaptureEnds[cap] >= pos.CaptureStarts[cap]);
                                Capture(cap, pos.CaptureStarts[cap], pos.CaptureEnds[cap]);
                            }
                        }
                    }
                    else
                    {
                        Capture(0, start, end);
                    }

                    runtextpos = end;
                }
                else
                {
                    // If we failed to find a match in the entire remainder of the input, skip the current position to the end.
                    // The calling scan loop will then exit.
                    runtextpos = text.Length;
                }
            }
        }
    }
}

#endif