// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.InteractionTargetCacheComparer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary>A custom comparer that ignores differences in HitPos, HitNormal and UncachedParams.</summary>
public class InteractionTargetCacheComparer : IEqualityComparer<InteractionTarget>
{
  public bool Equals(InteractionTarget x, InteractionTarget y);

  /// <summary> Excluded HitPos, HitNormal, and uncahced params, so targets can be considered same even if pointer is pointing at a different spot </summary>
  public static bool EqualsTest(InteractionTarget x, InteractionTarget y, bool ignoreNormals);

  /// <summary>Excluded hitpos and hitnormal from hashcode generation, hit information is not relevant to target comparison</summary>
  public int GetHashCode(InteractionTarget target);

  public static int GetHashCodeStatic(InteractionTarget target);
}
