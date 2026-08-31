// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.GroupAccumulatorUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

public static class GroupAccumulatorUtils
{
  /// <summary>Drains every whole unit the accumulator holds into <paramref name="outputs" />, one item per unit, built from that unit's exact composition by
  /// <paramref name="build" />. Returns null once less than a unit is left, or the reason it had to stop early — in which case the undrained mils stay put.</summary>
  public static LocString? TryFlush(
    this GroupAccumulator acc,
    InventoryCollection outputs,
    Func<IReadOnlyDictionary<Type, int>, Item> build);
}
