//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.StatsdClient
{
    /// <summary>
    /// DogStatsdEndPoint is a DogStatsd endpoint (UDP or UDS).
    /// </summary>
    internal class DogStatsdEndPoint
    {
        /// <summary>
        /// Gets or sets a value defining the name of the endpoint
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets a value defining the port number if any
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the name of the pipe. INTERNAL USAGE ONLY.
        /// </summary>
        public string PipeName { get; set; }

        /// <summary>
        /// AreEquals returns whether `this` and `endPoint` have the same values
        /// </summary>
        /// <param name="endPoint">The endpoint to compare with `this`</param>
        /// <returns>Returns whether `this` and `endPoint` have the same values</returns>
        public bool AreEquals(DogStatsdEndPoint endPoint)
        {
            return endPoint != null
            && this.ServerName == endPoint.ServerName
            && this.Port == endPoint.Port
            && this.PipeName == endPoint.PipeName;
        }
    }
}