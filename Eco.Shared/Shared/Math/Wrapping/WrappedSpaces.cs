// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Wrapping.WrappedSpaces
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Math.Wrapping;

/// <summary>Holder for wrapped spaces (world, chunk and plot).</summary>
public static class WrappedSpaces
{
  public static WrappedSpace World;
  public static WrappedSpace Chunk;
  public static WrappedSpace Plot;

  public static void SetWrappedWorldSize(Vector3i voxelSize);
}
