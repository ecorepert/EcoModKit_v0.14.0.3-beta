// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Ray
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Math;

[Serialized]
public class Ray
{
  public static readonly Ray None;
  public static readonly Ray Forward;
  public static readonly Ray Back;
  public static readonly Ray Left;
  public static readonly Ray Right;
  public static readonly Ray Up;
  public static readonly Ray Down;
  [Serialized]
  public Vector3i Pos;
  [Serialized]
  public Direction Dir;

  public Ray();

  public Ray(Vector3i pos, Direction dir);

  public Ray(int x, int y, int z, Direction dir);

  public Vector3i FirstPos { get; }

  public Ray FirstRay { get; }

  public static Ray Project(WrappedPosition3i fromPos, WrappedPosition3i toPos);

  public override bool Equals(object obj);

  public override int GetHashCode();
}
