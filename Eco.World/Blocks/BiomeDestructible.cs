// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.BiomeDestructible
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable enable
namespace Eco.World.Blocks;

/// <summary> This block type may be destructed by Biome block. If no <see cref="P:Eco.World.Blocks.BiomeDestructible.DestructedBy" /> blocks specified then may be destructed by any biome block. </summary>
public sealed class BiomeDestructible : BlockAttribute
{
  /// <summary> Block types by which this block may be destructed. </summary>
  public Type[] DestructedBy { get; }

  public BiomeDestructible(params Type[] destructedBy);
}
