// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Threshold.DoubleThreshold
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Threshold;

public struct DoubleThreshold : IThreshold<double>
{
  public readonly double Value;
  private double totalDelta;

  public DoubleThreshold(double value);

  public bool TryPass(double delta);

  public bool UpdateValue(ref double value, double newValue);

  public bool ClampValue(ref double value, double newValue, double minValue, double maxValue);
}
