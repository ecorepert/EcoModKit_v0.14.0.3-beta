// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.TalentGroup
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Skills;

[Serialized]
[System.ComponentModel.Category("Hidden")]
[Tag("NotInBrowser")]
[ItemGroup("Talents")]
public abstract class TalentGroup : Item, INotifyPropertyChanged
{
  public 
  #nullable disable
  Type OwningSkill;
  /// <summary>Optional delegate overriding <see cref="P:Eco.Gameplay.Skills.TalentGroup.StarCost" /> per user for dynamic pricing (e.g. company-scoped costs). Null delegate or null result = the group's <see cref="P:Eco.Gameplay.Skills.TalentGroup.StarCost" />, so a mod can override selectively per call.</summary>
  public static Func<User, TalentGroup, int?> CalculateStarCost;

  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public int Level { get; set; }

  /// <summary>Star cost to learn this talent group. Default 1. Override in subclass for custom costs.</summary>
  [SyncToView(null, true)]
  public virtual int StarCost { get; set; }

  /// <summary>Effective star cost of this group for the given user.</summary>
  public int StarCostFor(User user);

  /// <summary>Maximum talent level. Players start at level 1 when learned. Auto-computed from bonuses during initialization (talents with level-scaling effects get 5, others stay 1). Override in subclass for custom caps.</summary>
  [SyncToView(null, true)]
  public virtual int MaxTalentLevel { get; set; }

  public Type[] Talents { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<string> TalentStrings { get; }

  [SyncToView(null, true)]
  public bool TalentsEnabled { get; }

  /// <summary>Classification of the talent's effects for UI cues. Computed from the underlying bonuses. Named TalentKind to avoid collision with Item.Category.</summary>
  [SyncToView(null, true)]
  public TalentCategory TalentKind { get; }

  [RPC]
  public void LearnTalent(User user);

  [RPC]
  public void LevelUpTalent(User user);

  public void UnLearnTalent(User user);
}
