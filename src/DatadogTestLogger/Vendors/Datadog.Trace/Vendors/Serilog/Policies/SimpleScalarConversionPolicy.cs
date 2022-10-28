//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
// Copyright 2013-2017 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.Serilog.Core;
using Datadog.Trace.Vendors.Datadog.Trace.Vendors.Serilog.Events;

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.Serilog.Policies
{
    class SimpleScalarConversionPolicy : IScalarConversionPolicy
    {
        readonly HashSet<Type> _scalarTypes;

        public SimpleScalarConversionPolicy(IEnumerable<Type> scalarTypes)
        {
            _scalarTypes = new HashSet<Type>(scalarTypes);
        }

        public bool TryConvertToScalar(object value, out ScalarValue result)
        {
            if (_scalarTypes.Contains(value.GetType()))
            {
                result = new ScalarValue(value);
                return true;
            }

            result = null;
            return false;
        }
    }
}
