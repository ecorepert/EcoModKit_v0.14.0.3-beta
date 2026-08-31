// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.RadPoint
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Gameplay;

[Serialized]
public readonly struct RadPoint
{
  public readonly Vector2 Pos;
  public readonly float Radius;

  public float RadiusSq { get; }

  public RadPoint(Vector2 pos, float radius);

  public static RadPoint operator *(RadPoint a, float scalar);

  public static RadPoint operator +(RadPoint a, float val);

  /// <summary>Returns true if this position is within the range of this point.</summary>
  public bool Covers(Vector2 testPos);

  /// <summary>Check coverage within a given percent</summary>
  public bool Covers(float percent, Vector2 testPos);
}
