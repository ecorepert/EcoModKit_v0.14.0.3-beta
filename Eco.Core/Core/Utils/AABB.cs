// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.AABB
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Numerics;

#nullable disable
namespace Eco.Core.Utils;

public struct AABB
{
  public Vector3 Min;
  public Vector3 Max;

  public float Volume { get; }

  public AABB(float minimum = float.PositiveInfinity, float maximum = float.NegativeInfinity);

  public AABB(Vector3 center, Vector3 fullWidth);

  public AABB Combine(ref AABB other);

  public bool IntersectsSphere(Sphere sphere);

  public bool IntersectsSphere(Vector3 center, float radius);

  public bool IntersectsAABB(AABB box);

  public bool Equals(AABB other);

  public Vector3 Center();

  public Vector3 Diff();

  public bool Contains(Vector3 point);

  public bool Contains(AABB aabb);

  public static AABB FromSphere(Vector3 pos, float radius);

  internal void ExpandToFit(AABB b);

  internal AABB ExpandedBy(AABB b);
}
