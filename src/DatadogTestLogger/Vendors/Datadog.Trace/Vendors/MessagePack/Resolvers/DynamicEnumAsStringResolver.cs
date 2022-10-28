//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#if !UNITY_WSA

using Datadog.Trace.Vendors.Datadog.Trace.Vendors.MessagePack.Formatters;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.MessagePack.Internal;
using System;
using System.Reflection;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.MessagePack.Resolvers
{
    internal sealed class DynamicEnumAsStringResolver : IFormatterResolver
    {
        public static readonly IFormatterResolver Instance = new DynamicEnumAsStringResolver();

        DynamicEnumAsStringResolver()
        {

        }

        public IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var ti = typeof(T).GetTypeInfo();

                if (ti.IsNullable())
                {
                    // build underlying type and use wrapped formatter.
                    ti = ti.GenericTypeArguments[0].GetTypeInfo();
                    if (!ti.IsEnum)
                    {
                        return;
                    }

                    var innerFormatter = DynamicEnumAsStringResolver.Instance.GetFormatterDynamic(ti.AsType());
                    if (innerFormatter == null)
                    {
                        return;
                    }
                    formatter = (IMessagePackFormatter<T>)Activator.CreateInstance(typeof(StaticNullableFormatter<>).MakeGenericType(ti.AsType()), new object[] { innerFormatter });
                    return;
                }
                else if (!ti.IsEnum)
                {
                    return;
                }

                formatter = (IMessagePackFormatter<T>)(object)new EnumAsStringFormatter<T>();
            }
        }
    }
}

#endif