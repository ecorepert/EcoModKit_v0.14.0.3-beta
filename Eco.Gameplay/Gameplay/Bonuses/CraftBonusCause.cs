// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.CraftBonusCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Crafting-specific cause. Triggers when the context action matches and recipe/skill/station/tag filters pass. </summary>
public class CraftBonusCause : BonusCause
{
  public BonusAction Action { get; init; }

  public HashSet<Type> Recipes { get; init; }

  public HashSet<Type> SkillTypes { get; init; }

  public HashSet<Type> ExcludedSkillTypes { get; init; }

  public HashSet<Type> CraftStationTypes { get; init; }

  public HashSet<string> ItemTags { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
