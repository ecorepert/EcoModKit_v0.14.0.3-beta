// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WorldArea
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Shared.Math;

[Serialized]
[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct WorldArea
{
  [Serialized]
  public Vector2i MinInclusive;
  [Serialized]
  public Vector2i MaxExclusive;

  public int Length { get; }

  public int Width { get; }

  public int Area { get; }

  public Vector2i Size { get; }

  public WorldArea(Vector2i minInclusive, Vector2i maxExclusive);

  public WorldArea(Vector2 center, float radius);

  public override 
  #nullable disable
  string ToString();

  public override bool Equals(object other);

  public bool Equals(WorldArea otherArea);

  public override int GetHashCode();

  public static bool operator ==(WorldArea left, WorldArea right);

  public static bool operator !=(WorldArea left, WorldArea right);

  public static WorldArea WholeWorld { get; }

  public bool IsInWorldArea();

  /// <summary>Enumerates wrapped areas in <paramref name="size" />. There may be more than one area if <see cref="T:Eco.Shared.Math.WorldArea" /> crossing the border. It assumes that <see cref="F:Eco.Shared.Math.WorldArea.MinInclusive" /> never less than -size for optimization purposes.</summary>
  /// <example>If <paramref name="size" /> is (100, 100) and area is (90, 90)-(110, 110) then this method will enumerate following areas: (90, 90)-(100, 100), (0, 90)-(10, 100), (90, 0)-(100, 10) and (0, 0)-(10,10).</example>
  public IEnumerable<WorldArea> WrappedAreas(Vector2i size);

  public IEnumerable<Vector2i> Iter();

  public readonly bool Contains(Vector2i pos);

  public bool Contains(WorldArea other);

  public bool Intersects(WorldArea other);

  public WorldArea Intersect(WorldArea other);

  public WorldArea Expand(int p);

  public Vector2 Center { get; }

  public WorldArea[] ChopToWorldAlignedCells(int cellVoxelSize);
}
