//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
// <copyright file="ITransport.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Threading.Tasks;
using Datadog.Trace.Vendors.Datadog.Trace.AppSec.Waf;
using Datadog.Trace.Vendors.Datadog.Trace.Headers;

namespace Datadog.Trace.Vendors.Datadog.Trace.AppSec.Transports
{
    internal interface ITransport
    {
        bool IsSecureConnection { get; }

        bool Blocked { get; }

        Func<string, string> GetHeader { get; }

        IContext GetAdditiveContext();

        void DisposeAdditiveContext();

        void SetAdditiveContext(IContext additiveContext);

        IHeadersCollection GetRequestHeaders();

        IHeadersCollection GetResponseHeaders();

        void WriteBlockedResponse(string templateJson, string templateHtml, bool canAccessHeaders);
    }
}
