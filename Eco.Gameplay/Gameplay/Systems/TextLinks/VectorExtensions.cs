// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.VectorExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

public static class VectorExtensions
{
  public static LocString UILink(this Eco.Shared.Math.Vector2 vector);

  public static LocString UILink(this Vector3 vector);

  public static LocString UILink(this Vector2i vector);

  public static LocString UILink(this PlotPos plotPos);

  public static LocString UILink(this Vector3i vector);

  public static LocString UILink(this WrappedWorldPosition3i vector);

  public static LocString UILink(this Eco.Shared.Math.Vector2 vector, string label);

  public static LocString UILink(this Vector3 vector, string label);

  public static LocString UILink(this Vector2i vector, string label);

  public static LocString UILink(this Vector3i vector, string label);
}
