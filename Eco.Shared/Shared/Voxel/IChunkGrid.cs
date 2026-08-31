// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.IChunkGrid
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Voxel;

/// <summary>Interface for all Chunk Grid implementations (both on server side and client-side). Chunk Grid is 3D grid of <see cref="T:Eco.Shared.Voxel.IChunk" /> objects.</summary>
public interface IChunkGrid
{
  event Action<Vector3i> SizeChangedEvent;

  Vector3i MinChunkPos { get; }

  Vector3i MaxChunkPos { get; }

  Vector3i WrappedChunkSize { get; }

  Vector3i WrappedVoxelSize { get; }

  IEnumerable<IChunk> GetVisibleChunks(Vector3 observerPosition, float viewDistance);

  IEnumerable<IChunk> GetChunks(WorldRange range);

  Vector3 ClosestWrappedLocation(Vector3 viewPosition, Vector3 position);

  /// <summary>Removes all chunks from grid.</summary>
  void Clear(Guid newGuid);
}
