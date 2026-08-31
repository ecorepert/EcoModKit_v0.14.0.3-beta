// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.Minable
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

#nullable disable
namespace Eco.World.Blocks;

/// <summary>Attribute used to mark a block as capable of being mined with a pickaxe.</summary>
public sealed class Minable : BlockAttribute
{
  /// <summary>
  /// Represnets the Min tier of pickaxe that can be used to mine this.
  /// </summary>
  public int Hardness { get; set; }

  public Minable(int hardness);
}
