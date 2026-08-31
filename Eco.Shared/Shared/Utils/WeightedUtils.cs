// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.WeightedUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary> Separate utils for weighted calculation on enumerable </summary>
public static class WeightedUtils
{
  /// <summary> Randomly selects N items from a list of already weighted objects </summary>
  public static 
  #nullable disable
  T WeightedRandom<T>(this IEnumerable<IWeightedEntry<T>> enumerable, int numToSelect = 1);

  /// <summary> Converts enumerable to weighted and randomly selects amount</summary>
  public static T WeightedRandom<T>(
    this IEnumerable<T> enumerable,
    Func<T, float> weightFunc,
    int numToSelect = 1);
}
