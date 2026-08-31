// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.AggregatedValue
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary>Aggregated value. May be used for optimized calculation of Min, Max, Sum, Count and Average.</summary>
public struct AggregatedValue
{
  public static readonly AggregatedValue Invalid;
  public double Min;
  public double Max;
  private SumAndCount sumAndCount;

  public double Sum { get; }

  public int Count { get; set; }

  public double Average { get; }

  public AggregatedValue();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Add(double value);
}
