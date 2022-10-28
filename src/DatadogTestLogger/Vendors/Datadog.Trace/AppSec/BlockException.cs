//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="BlockException.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;

namespace Datadog.Trace.Vendors.Datadog.Trace.AppSec
{
    internal class BlockException : Exception
    {
        internal BlockException()
        {
        }

        internal BlockException(string message)
            : base(message)
        {
        }

        internal BlockException(string message, Exception inner)
            : base(message, inner)
        {
        }

        internal BlockException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        // can give a significant performance boost, this exception is currently caught and logged by the host web server
        public override string ToString() => "BlockException";
    }
}
