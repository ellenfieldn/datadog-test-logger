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
using System.Diagnostics.CodeAnalysis;

namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.IndieSystem.Text.RegularExpressions
{
    internal partial class Regex
    {
        /// <summary>
        /// Searches the input string for one or more occurrences of the text supplied in the given pattern.
        /// </summary>
        public static bool IsMatch(string input, [StringSyntax(StringSyntaxAttribute.Regex)] string pattern) =>
            RegexCache.GetOrAdd(pattern).IsMatch(input);

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input span.
        /// </summary>
        /// <param name="input">The span to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns><see langword="true"/> if the regular expression finds a match; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="pattern"/> is <see langword="null"/></exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        public static bool IsMatch(ReadOnlySpan<char> input, [StringSyntax(StringSyntaxAttribute.Regex)] string pattern) =>
            RegexCache.GetOrAdd(pattern).IsMatch(input);

        /// <summary>
        /// Searches the input string for one or more occurrences of the text
        /// supplied in the pattern parameter with matching options supplied in the options
        /// parameter.
        /// </summary>
        public static bool IsMatch(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options) =>
            RegexCache.GetOrAdd(pattern, options, s_defaultMatchTimeout).IsMatch(input);

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input span, using the specified matching options.
        /// </summary>
        /// <param name="input">The span to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns><see langword="true"/> if the regular expression finds a match; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="pattern"/> is <see langword="null"/></exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="options"/> is not in a valid <see cref="RegexOptions"/> value.</exception>
        public static bool IsMatch(ReadOnlySpan<char> input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options) =>
            RegexCache.GetOrAdd(pattern, options, s_defaultMatchTimeout).IsMatch(input);

        public static bool IsMatch(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options, TimeSpan matchTimeout) =>
            RegexCache.GetOrAdd(pattern, options, matchTimeout).IsMatch(input);

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input span, using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="input">The span to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="matchTimeout">A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.</param>
        /// <returns><see langword="true"/> if the regular expression finds a match; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="pattern"/> is <see langword="null"/></exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="options"/> is not in a valid <see cref="RegexOptions"/> value or <paramref name="matchTimeout"/> is negative,
        /// zero, or greater than approximately 24 days.</exception>
        public static bool IsMatch(ReadOnlySpan<char> input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options, TimeSpan matchTimeout) =>
            RegexCache.GetOrAdd(pattern, options, matchTimeout).IsMatch(input);

        /// <summary>
        /// Searches the input string for one or more matches using the previous pattern,
        /// options, and starting position.
        /// </summary>
        public bool IsMatch(string input)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return RunSingleMatch(RegexRunnerMode.ExistenceRequired, -1, input, 0, input.Length, RightToLeft ? input.Length : 0) is null;
        }

        /// <summary>
        /// Searches the input string for one or more matches using the previous pattern and options,
        /// with a new starting position.
        /// </summary>
        public bool IsMatch(string input, int startat)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return RunSingleMatch(RegexRunnerMode.ExistenceRequired, -1, input, 0, input.Length, startat) is null;
        }

        /// <summary>
        /// Indicates whether the regular expression specified in the Regex constructor finds a match in a specified input span.
        /// </summary>
        /// <param name="input">The span to search for a match.</param>
        /// <returns><see langword="true"/> if the regular expression finds a match; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        public bool IsMatch(ReadOnlySpan<char> input) =>
            IsMatch(input, RightToLeft ? input.Length : 0);

        /// <summary>
        /// Indicates whether the regular expression specified in the Regex constructor finds a match in a specified input span.
        /// </summary>
        /// <param name="input">The span to search for a match.</param>
        /// <param name="startat">The zero-based character position at which to start the search.</param>
        /// <returns><see langword="true"/> if the regular expression finds a match; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        public bool IsMatch(ReadOnlySpan<char> input, int startat) =>
            RunSingleMatch(RegexRunnerMode.ExistenceRequired, -1, input, startat).Success;

        /// <summary>
        /// Searches the input string for one or more occurrences of the text
        /// supplied in the pattern parameter.
        /// </summary>
        public static Match Match(string input, [StringSyntax(StringSyntaxAttribute.Regex)] string pattern) =>
            RegexCache.GetOrAdd(pattern).Match(input);

        /// <summary>
        /// Searches the input string for one or more occurrences of the text
        /// supplied in the pattern parameter. Matching is modified with an option
        /// string.
        /// </summary>
        public static Match Match(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options) =>
            RegexCache.GetOrAdd(pattern, options, s_defaultMatchTimeout).Match(input);

        public static Match Match(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options, TimeSpan matchTimeout) =>
            RegexCache.GetOrAdd(pattern, options, matchTimeout).Match(input);

        /// <summary>
        /// Matches a regular expression with a string and returns
        /// the precise result as a Match object.
        /// </summary>
        public Match Match(string input)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return RunSingleMatch(RegexRunnerMode.FullMatchRequired, -1, input, 0, input.Length, RightToLeft ? input.Length : 0)!;
        }

        /// <summary>
        /// Matches a regular expression with a string and returns
        /// the precise result as a Match object.
        /// </summary>
        public Match Match(string input, int startat)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return RunSingleMatch(RegexRunnerMode.FullMatchRequired, -1, input, 0, input.Length, startat)!;
        }

        /// <summary>
        /// Matches a regular expression with a string and returns the precise result as a Match object.
        /// </summary>
        public Match Match(string input, int beginning, int length)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return RunSingleMatch(RegexRunnerMode.FullMatchRequired, -1, input, beginning, length, RightToLeft ? beginning + length : beginning)!;
        }

        /// <summary>
        /// Returns all the successful matches as if Match were called iteratively numerous times.
        /// </summary>
        public static MatchCollection Matches(string input, [StringSyntax(StringSyntaxAttribute.Regex)] string pattern) =>
            RegexCache.GetOrAdd(pattern).Matches(input);

        /// <summary>
        /// Returns all the successful matches as if Match were called iteratively numerous times.
        /// </summary>
        public static MatchCollection Matches(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options) =>
            RegexCache.GetOrAdd(pattern, options, s_defaultMatchTimeout).Matches(input);

        public static MatchCollection Matches(string input, [StringSyntax(StringSyntaxAttribute.Regex, "options")] string pattern, RegexOptions options, TimeSpan matchTimeout) =>
            RegexCache.GetOrAdd(pattern, options, matchTimeout).Matches(input);

        /// <summary>
        /// Returns all the successful matches as if Match was called iteratively numerous times.
        /// </summary>
        public MatchCollection Matches(string input)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return new MatchCollection(this, input, RightToLeft ? input.Length : 0);
        }

        /// <summary>
        /// Returns all the successful matches as if Match was called iteratively numerous times.
        /// </summary>
        public MatchCollection Matches(string input, int startat)
        {
            if (input is null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
            }

            return new MatchCollection(this, input, startat);
        }
    }
}

#endif