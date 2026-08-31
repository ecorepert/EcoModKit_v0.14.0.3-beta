// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.SumAndCount
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary>Sum and count aggregation. Can be used for <see cref="P:Eco.Shared.Tools.SumAndCount.Average" /> calculation.</summary>
public struct SumAndCount
{
  public double Sum;
  public int Count;

  public double Average { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Add(double value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Remove(double value);
}
