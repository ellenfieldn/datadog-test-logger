//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#nullable enable
// <copyright file="UnboundedSizeDenseStore.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2022 Datadog, Inc.
// </copyright>

#pragma warning disable SA1600 // Elements should be documented

namespace Datadog.Trace.Vendors.Datadog.Trace.Vendors.Datadog.Sketches.Stores;

/// <summary>
/// A dense store implementation with unbounded size.
/// </summary>
internal class UnboundedSizeDenseStore : DenseStore
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnboundedSizeDenseStore"/> class.
    /// </summary>
    public UnboundedSizeDenseStore()
    {
    }

    public UnboundedSizeDenseStore(int arrayLengthGrowthIncrement)
        : base(arrayLengthGrowthIncrement)
    {
    }

    public UnboundedSizeDenseStore(int arrayLengthGrowthIncrement, int arrayLengthOverhead)
        : base(arrayLengthGrowthIncrement, arrayLengthOverhead)
    {
    }

    private UnboundedSizeDenseStore(UnboundedSizeDenseStore store)
        : base(store)
    {
    }

    /// <inheritdoc />
    public override Store Copy() => new UnboundedSizeDenseStore(this);

    /// <inheritdoc />
    public override void MergeWith(Store store)
    {
        if (store is UnboundedSizeDenseStore unboundedStore)
        {
            MergeWith(unboundedStore);
        }
        else
        {
            base.MergeWith(store);
        }
    }

    /// <inheritdoc />
    protected override int Normalize(int index)
    {
        if (index < MinIndex || index > MaxIndex)
        {
            ExtendRange(index);
        }

        return index - Offset;
    }

    /// <inheritdoc />
    protected override void Adjust(int newMinIndex, int newMaxIndex)
    {
        CenterCounts(newMinIndex, newMaxIndex);
    }

    private void MergeWith(UnboundedSizeDenseStore store)
    {
        if (store.IsEmpty())
        {
            return;
        }

        if (store.MinIndex < MinIndex || store.MaxIndex > MaxIndex)
        {
            ExtendRange(store.MinIndex, store.MaxIndex);
        }

        for (var index = store.MinIndex; index <= store.MaxIndex; index++)
        {
            Counts[index - Offset] += store.Counts[index - store.Offset];
        }
    }
}
