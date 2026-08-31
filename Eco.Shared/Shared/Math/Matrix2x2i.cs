// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Matrix2x2i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Simple 2x2 integer matrix.</summary>
public struct Matrix2x2i
{
  public static Matrix2x2i Identity;
  public Vector2i C0;
  public Vector2i C1;

  public Matrix2x2i(Vector2i c0, Vector2i c1);

  public Matrix2x2i(int m00, int m10, int m01, int m11);

  public Vector2i Mul(Vector2i pos);
}
