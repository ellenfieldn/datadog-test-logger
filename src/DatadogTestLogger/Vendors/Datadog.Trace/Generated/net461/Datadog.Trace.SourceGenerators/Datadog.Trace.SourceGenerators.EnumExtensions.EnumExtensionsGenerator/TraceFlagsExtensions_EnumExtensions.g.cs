//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#if NETFRAMEWORK
// <auto-generated />

#nullable enable

namespace DatadogTestLogger.Vendors.Datadog.Trace.Propagators;

/// <summary>
/// Extension methods for <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags" />
/// </summary>
internal static partial class TraceFlagsExtensions
{
    /// <summary>
    /// The number of members in the enum.
    /// This is a non-distinct count of defined names.
    /// </summary>
    public const int Length = 2;

    /// <summary>
    /// Returns the string representation of the <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags"/> value.
    /// If the attribute is decorated with a <c>[Description]</c> attribute, then
    /// uses the provided value. Otherwise uses the name of the member, equivalent to
    /// calling <c>ToString()</c> on <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value to retrieve the string value for</param>
    /// <returns>The string representation of the value</returns>
    public static string ToStringFast(this Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags value)
        => value switch
        {
            Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.None => nameof(Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.None),
            Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.Sampled => nameof(Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.Sampled),
            _ => value.ToString(),
        };
        /// <summary>
        /// Determines whether one or more bit fields are set in the current instance.
        /// Equivalent to calling <see cref="System.Enum.HasFlag" /> on <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value of the instance to investigate</param>
        /// <param name="flag">The flag to check for</param>
        /// <returns><c>true</c> if the fields set in the flag are also set in the current instance; otherwise <c>false</c>.</returns>
        /// <remarks>If the underlying value of <paramref name="flag"/> is zero, the method returns true.
        /// This is consistent with the behaviour of <see cref="System.Enum.HasFlag" /></remarks>
        public static bool HasFlagFast(this Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags value, Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags flag)
            => flag == 0 ? true : (value & flag) == flag;

    /// <summary>
    /// Retrieves an array of the values of the members defined in
    /// <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags" />.
    /// Note that this returns a new array with every invocation, so
    /// should be cached if appropriate.
    /// </summary>
    /// <returns>An array of the values defined in <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags" /></returns>
    public static Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags[] GetValues()
        => new []
        {
            Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.None,
            Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.Sampled,
        };

    /// <summary>
    /// Retrieves an array of the names of the members defined in
    /// <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags" />.
    /// Note that this returns a new array with every invocation, so
    /// should be cached if appropriate.
    /// Ignores <c>[Description]</c> definitions.
    /// </summary>
    /// <returns>An array of the names of the members defined in <see cref="Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags" /></returns>
    public static string[] GetNames()
        => new []
        {
            nameof(Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.None),
            nameof(Datadog.Trace.Propagators.W3CTraceContextPropagator.TraceFlags.Sampled),
        };
}
#endif