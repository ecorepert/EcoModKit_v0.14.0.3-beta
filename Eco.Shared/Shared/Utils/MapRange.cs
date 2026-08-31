// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MapRange
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Creates a mapping from one range to another, clamped.</summary>
public struct MapRange
{
  private float minInput;
  private float maxInput;
  private float minOutput;
  private float maxOutput;

  public MapRange(float minInput, float maxInput, float minOutput, float maxOutput);

  public float MapValue(float value);
}
