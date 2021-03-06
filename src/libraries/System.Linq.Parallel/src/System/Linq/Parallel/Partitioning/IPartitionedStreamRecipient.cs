// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// IPartitionedStreamRecipient.cs
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace System.Linq.Parallel
{
    /// <summary>
    /// IPartitionedStreamRecipient is essentially a generic action on a partitioned stream,
    /// whose generic type parameter is the type of the order keys in the partitioned stream.
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    internal interface IPartitionedStreamRecipient<TElement>
    {
        void Receive<TKey>(PartitionedStream<TElement, TKey> partitionedStream);
    }
}
