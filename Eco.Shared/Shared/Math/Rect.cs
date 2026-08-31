// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Rect
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Math;

[Serialized]
public struct Rect
{
  public Vector2 Min;
  public Vector2 Max;
  public static readonly Rect One;

  public Vector2 Size { get; }

  public Vector2 Center { get; }

  public float Width { get; }

  public float Height { get; }

  public float Left { get; }

  public float Right { get; }

  public float Bottom { get; }

  public float Top { get; }

  public Vector2 TopLeft { get; }

  public Vector2 TopRight { get; }

  public Vector2 BottomLeft { get; }

  public Vector2 BottomRight { get; }

  public bool Intersects(Rect other);

  public bool Contains(Rect other);

  public bool Contains(Vector2 position);

  public bool Contains(Vector3 position);

  public static Rect operator +(Rect a, Vector3 offset);
}
