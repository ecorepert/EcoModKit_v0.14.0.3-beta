// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.PackedChunkPosition
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Packed chunk position. Useful when you need to use chunk position as lookup key (i.e. in Dictionary) for faster checks and compact storage.</summary>
public struct PackedChunkPosition
{
  private static VectorPacker3Int packer;
  private int packedYZX;

  public static void Initialize(Vector2i chunksInWorld);

  public int X { get; set; }

  public int Y { get; set; }

  public int Z { get; set; }

  public static implicit operator Vector3i(PackedChunkPosition packed);

  public static explicit operator PackedChunkPosition(Vector3i value);
}
