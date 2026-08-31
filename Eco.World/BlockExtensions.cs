// Decompiled with JetBrains decompiler
// Type: Eco.World.BlockExtensions
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.World.Blocks;

#nullable enable
namespace Eco.World;

/// <summary>Static extension methods for <see cref="T:Eco.World.Blocks.Block" /> objects.</summary>
public static class BlockExtensions
{
  /// <summary>
  /// returns the assigned ID for this block type.
  /// This ID should be considered transient, as it can change easily.
  /// </summary>
  /// <param name="block">Block to retrieve the id of.</param>
  /// <returns>ushort representing the block's identifier.</returns>
  public static ushort GetID(this Block block);
}
