// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawSelectionMemo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Settlements;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

/// <summary>Per-<see cref="T:Eco.Gameplay.GameActions.GameActionPack" /> memo for the settlement-filtered applicable-law set, so the N actions of a bulk move resolve the law list once instead of once per action. Lives only for the duration of a single (serialized) pack evaluation, so it needs no locking or invalidation.</summary>
public sealed class LawSelectionMemo
{
  public bool TryGet(Type actionType, List<Settlement> scope, out IReadOnlyList<Law> laws);

  public void Store(Type actionType, List<Settlement> scope, IReadOnlyList<Law> laws);
}
