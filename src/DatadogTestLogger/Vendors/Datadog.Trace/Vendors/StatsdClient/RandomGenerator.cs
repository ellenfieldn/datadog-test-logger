//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
namespace DatadogTestLogger.Vendors.Datadog.Trace.Vendors.StatsdClient
{
    internal class RandomGenerator : IRandomGenerator
    {
        private readonly ThreadSafeRandom _random;

        public RandomGenerator()
        {
            _random = new ThreadSafeRandom();
        }

        public bool ShouldSend(double sampleRate)
        {
            return _random.NextDouble() < sampleRate;
        }
    }
}