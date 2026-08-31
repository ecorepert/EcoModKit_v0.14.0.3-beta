// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.WorldExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Voxel;

public static class WorldExtensions
{
  public static LocString DescribeDistance(
    IPositionAndBounds me,
    IPositionAndBounds other,
    bool shortDesc = false);

  public static LocString DescribeDistance(this Vector3 mypos, Vector3 otherPos, bool shortDesc = false);

  public static LocString DescribeDistance(this Eco.Shared.Math.Vector2 mypos, Eco.Shared.Math.Vector2 otherPos, bool shortDesc = false);

  public static LocString DescribeDistance(this Eco.Shared.Math.Vector2 toDest, float dist, bool shortDesc = false);
}
