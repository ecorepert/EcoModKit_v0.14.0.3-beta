// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Blocks.FractionalBlockUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Blocks;

/// <summary>Pure math utilities for fractional blocks, shared between server and client.</summary>
public static class FractionalBlockUtils
{
  /// <summary>Returns the 0-based index into a block's form array for a given fractional fill level.
  /// The last index is reserved exclusively for full blocks; all others are divided into (n-1) equal segments.</summary>
  public static int GetBlockFormIndex(float totalQuantity, float maxQuantity, int blockTypeCount);
}
