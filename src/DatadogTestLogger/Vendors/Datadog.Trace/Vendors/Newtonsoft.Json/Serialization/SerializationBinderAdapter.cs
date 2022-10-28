//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612
#nullable enable
#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Runtime.Serialization;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.Newtonsoft.Json.Serialization
{
    internal class SerializationBinderAdapter : ISerializationBinder
    {
#pragma warning disable 618
        public readonly SerializationBinder SerializationBinder;
#pragma warning restore 618

#pragma warning disable 618
        public SerializationBinderAdapter(SerializationBinder serializationBinder)
        {
            SerializationBinder = serializationBinder;
        }
#pragma warning restore 618

        public Type BindToType(string? assemblyName, string typeName)
        {
            return SerializationBinder.BindToType(assemblyName, typeName);
        }

        public void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
        {
#if HAVE_SERIALIZATION_BINDER_BIND_TO_NAME
            SerializationBinder.BindToName(serializedType, out assemblyName, out typeName);
#else
            assemblyName = null;
            typeName = null;
#endif
        }
    }
}