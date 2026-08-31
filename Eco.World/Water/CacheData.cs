// Decompiled with JetBrains decompiler
// Type: Eco.World.Water.CacheData
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.World.Water;

/// <summary>
/// Data in the cache, the type of the block and the level of the water.
/// Used to restore the old water block after picking up the object (and to know which level of water the block had).
/// </summary>
[Serialized]
internal struct CacheData
{
  [Serialized]
  public Type Type;
  [Serialized]
  public float Level;

  public CacheData(Type type, float level);
}
