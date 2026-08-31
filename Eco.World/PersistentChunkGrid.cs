// Decompiled with JetBrains decompiler
// Type: Eco.World.PersistentChunkGrid
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.World;

public class PersistentChunkGrid : WorldChunkGrid
{
  public override PersistentChunk CreateChunk(Vector3i chunkPos);

  public override void RemoveChunk(PersistentChunk chunk);

  public void Initialize();

  public void MarkAllDirty();

  public void GetDirtyState(out int numDirty, out int total);

  public override void Clear(Guid newGuid);
}
