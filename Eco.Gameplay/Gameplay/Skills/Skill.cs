// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.Skill
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Skills;

[Serialized]
[Tag("NotAllowedInInventories")]
[ItemGroup("Skills")]
public abstract class Skill : 
  Item,
  ILinkableParameterized<int>,
  ILinkable,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  /// <summary>Optional delegate that overrides <see cref="P:Eco.Gameplay.Skills.Skill.EffectiveSpecialtyCost" /> for dynamic per-user costs. Null delegate or null result = default formula, so a mod can override selectively per call.</summary>
  public static 
  #nullable disable
  Func<User, Type, int?> CalculateStarsNeededForSpecialty;

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public static ThreadSafeAction OnSkillsChanged { get; }

  public static Skill[] AllSkills { get; }

  /// <summary>The user who owns this skill instance (set by Skillset). Null for static/template skills.</summary>
  internal User Owner { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int Level { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float Experience { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float Education { get; set; }

  [Serialized]
  public int StarsSpent { get; set; }

  [Serialized]
  public User Teacher { get; set; }

  [Serialized]
  public double TimeLearned { get; }

  [SyncToView(null, true)]
  public virtual int MaxLevel { get; }

  [SyncToView(null, true)]
  public virtual int Tier { get; }

  /// <summary>Base star cost to learn this specialty. Override in partial class extensions for per-skill costs.
  /// ONLY FOR OVERRIDES. USE BaseSpecialtyCost in ALL CALLS.</summary>
  [SyncToView(null, true)]
  public virtual int SpecialtyCost { get; }

  [SyncToView(null, true)]
  public int BaseSpecialtyCost { get; }

  /// <summary>Effective per-user cost accounting for <see cref="P:Eco.Shared.Services.AdvancedGameSettings.CostPerAdditionalSpecialty" /> scaling. Excludes Self Improvement from count.</summary>
  [SyncToView(null, true)]
  public int EffectiveSpecialtyCost { get; }

  /// <summary>Recalculates <see cref="P:Eco.Gameplay.Skills.Skill.EffectiveSpecialtyCost" /> from current state.</summary>
  internal void UpdateEffectiveSpecialtyCost();

  [SyncToView(null, true)]
  public RequiresSkillAttribute[] Prerequisites { get; }

  [SyncToView(null, true)]
  public bool IsRoot { get; }

  [SyncToView(null, true)]
  public bool IsSpecialty { get; }

  [SyncToView(null, true)]
  public SkillTree RootSkillTree { get; }

  [SyncToView(null, true)]
  public SkillTree SpecialtySkillTree { get; }

  [SyncToView(null, true)]
  public SkillTree SkillTree { get; }

  [SyncToView(null, true)]
  public List<TalentGroup> Talents { get; }

  [SyncToView(null, true)]
  [DependsOn("Level")]
  public float ExperienceToLevel { get; }

  [SyncToView(null, true)]
  [DependsOn("Experience", new string[] {"ExperienceToLevel"})]
  public float PercentTowardsNextLevel { get; }

  public virtual void OnLearned(User user);

  public virtual void OnReset(User user);

  public virtual void OnLevelUp(User user);

  public virtual string Title { get; }

  public virtual MultiplicativeStrategy MultiStrategy { get; }

  public virtual AdditiveStrategy AddStrategy { get; }

  public float Multiplier { get; }

  public LocString UILinkContent(int count);

  public static bool ShouldShowSkills(User user);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public LocString NameAndLevel(int currentLevel, bool showText);

  public virtual bool CanBeRefunded { get; }

  /// <summary> Static skill initializer. </summary>
  public static void InitializeSkills();

  public static void BuildUnlocks();

  public override Item Clone();

  internal bool AddExperience(float exp, User user);

  public void ResetTalents(User user);

  public void DebugSetLevel(int level);

  public Task<Result> Learn(User user, bool selfTeach, bool spendSkillPoints = true, bool force = false);

  public Skill Profession { get; }

  public Task<Result> Unlearn(User user, float percentageOfXp, bool isSelf = false, bool force = false);

  public override string ToString();

  public void ForceSetLevel(User user, int level);

  public bool IsDiscovered();

  [RPC]
  public void LevelUpMax(User user);
}
