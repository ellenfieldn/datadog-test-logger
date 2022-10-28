//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="NativeCallTargetDefinition.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Runtime.InteropServices;

namespace Datadog.Trace.Vendors.Datadog.Trace.ClrProfiler
{
 // !                                         ██
 //                                         ██░░██
 //                                       ██░░░░░░██
 //                                     ██░░░░░░░░░░██
 //                                     ██░░░░░░░░░░██
 //                                   ██░░░░░░░░░░░░░░██
 //                                 ██░░░░░░██████░░░░░░██
 //                                 ██░░░░░░██████░░░░░░██
 //                               ██░░░░░░░░██████░░░░░░░░██
 //                               ██░░░░░░░░██████░░░░░░░░██
 //                             ██░░░░░░░░░░██████░░░░░░░░░░██
 //                           ██░░░░░░░░░░░░██████░░░░░░░░░░░░██
 //                           ██░░░░░░░░░░░░██████░░░░░░░░░░░░██
 //                         ██░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░██
 //                         ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
 //                       ██░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░░░██
 //                       ██░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░░░██
 //                     ██░░░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░░░░░██
 //                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
 //                       ██████████████████████████████████████████
 //
 // If you happen to change the layout of this structure,
 // this will lead to an AccessViolationException in netCore when using a more recent version of the nuget.
 // If you need to modify the definition, create a new interface NativeCallTargetDefinition# that will be consumed by the native layer

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct NativeCallTargetDefinition
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string TargetAssembly;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string TargetType;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string TargetMethod;

        public IntPtr TargetSignatureTypes;

        public ushort TargetSignatureTypesLength;

        public ushort TargetMinimumMajor;

        public ushort TargetMinimumMinor;

        public ushort TargetMinimumPatch;

        public ushort TargetMaximumMajor;

        public ushort TargetMaximumMinor;

        public ushort TargetMaximumPatch;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string IntegrationAssembly;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string IntegrationType;

        public NativeCallTargetDefinition(
                string targetAssembly,
                string targetType,
                string targetMethod,
                string[] targetSignatureTypes,
                ushort targetMinimumMajor,
                ushort targetMinimumMinor,
                ushort targetMinimumPatch,
                ushort targetMaximumMajor,
                ushort targetMaximumMinor,
                ushort targetMaximumPatch,
                string integrationAssembly,
                string integrationType)
        {
            TargetAssembly = targetAssembly;
            TargetType = targetType;
            TargetMethod = targetMethod;
            TargetSignatureTypes = IntPtr.Zero;
            if (targetSignatureTypes?.Length > 0)
            {
                TargetSignatureTypes = Marshal.AllocHGlobal(targetSignatureTypes.Length * Marshal.SizeOf(typeof(IntPtr)));
                var ptr = TargetSignatureTypes;
                for (var i = 0; i < targetSignatureTypes.Length; i++)
                {
                    Marshal.WriteIntPtr(ptr, Marshal.StringToHGlobalUni(targetSignatureTypes[i]));
                    ptr += Marshal.SizeOf(typeof(IntPtr));
                }
            }

            TargetSignatureTypesLength = (ushort)(targetSignatureTypes?.Length ?? 0);
            TargetMinimumMajor = targetMinimumMajor;
            TargetMinimumMinor = targetMinimumMinor;
            TargetMinimumPatch = targetMinimumPatch;
            TargetMaximumMajor = targetMaximumMajor;
            TargetMaximumMinor = targetMaximumMinor;
            TargetMaximumPatch = targetMaximumPatch;
            IntegrationAssembly = integrationAssembly;
            IntegrationType = integrationType;
        }

        public void Dispose()
        {
            var ptr = TargetSignatureTypes;
            for (var i = 0; i < TargetSignatureTypesLength; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr));
                ptr += Marshal.SizeOf(typeof(IntPtr));
            }

            Marshal.FreeHGlobal(TargetSignatureTypes);
        }
    }
}
