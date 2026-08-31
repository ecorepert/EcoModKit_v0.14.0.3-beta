// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.Skillset
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Skills;

[Serialized]
[ChatCommandHandler]
public class Skillset : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  /// <summary> Raised when any skill of any user changes level </summary>
  public static 
  #nullable disable
  ThreadSafeAction<User, Skill> UserSkillLevelChangedEvent;
  public static ThreadSafeAction<User, Skill> OnExperienceGained;
  public ThreadSafeAction<Skill> OnSkillLevelChanged;

  public ThreadSafeAction OnAddExperience { get; }

  [SyncToView(null, true)]
  public int SpecialtyCount { get; }

  [SyncToView(null, true)]
  public int RefundableSpecialties { get; }

  [SyncToView(null, true)]
  public int ProfessionCount { get; }

  /// <summary>Synced copy of <see cref="P:Eco.Shared.Services.AdvancedGameSettings.CostPerAdditionalSpecialty" /> so clients can compute effective cost for unlearned specialties.</summary>
  [SyncToView(null, true)]
  public float CostPerAdditionalSpecialty { get; }

  [SyncToView(null, true)]
  [Serialized]
  public ThreadSafeList<int> LastSkillsGained { get; }

  [Serialized]
  public ThreadSafeHashSet<Type> QueuedLevelUps { get; set; }

  [Serialized]
  public int ScrollsRead { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Skill[] Skills { get; set; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 101, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString SkillsetTooltip(TooltipOrigin origin);

  [RPC]
  public TooltipSection EducationTooltip(Player player);

  public void LearnSkillAndNotify(Skill skill);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public void Clear();

  public void Reset();

  public Task<(bool Result, Skill OwnedSkill)> Reset(Type skillType, bool isSelf = false);

  public bool ResetTalentsInTree(Type skillType);

  public Skill this[Type skillType] { get; }

  public bool HasSkill(Type skillType);

  public Skill GetSkill(SkillTree tree);

  public Skill GetSkill(Type skillType);

  public bool HasProfession(Type skillType);

  public Skill GetOrAddSkill(Type skillType);

  public void RefreshSkills();

  public Skill LearnSkill(Type skillType);

  public Task UnLearnSkillInSkillset(Type skillType, User user);

  public bool AddExperience(
    Type skillType,
    float skillRate,
    float exp,
    GameActionDescription desc);

  public bool AddExperience(Type skillType, float exp, GameActionDescription desc);

  public bool AddExperience(Type skillType, float exp, LocString desc);

  public bool AddExperience(Type skillType, float skillRate, float exp, LocString desc);

  public void PointsChanged(User user, Skill skill);

  public void SetOwner(User owner);

  /// <summary>Recalculates <see cref="P:Eco.Gameplay.Skills.Skill.EffectiveSpecialtyCost" /> on all skills and re-syncs the Skills array so clients receive updated values.
  /// Public so mods with external cost rules (e.g. company-scoped pricing via <see cref="F:Eco.Gameplay.Skills.Skill.CalculateStarsNeededForSpecialty" />) can refresh every affected user when a rule changes, not just the one who triggered it.</summary>
  public void NotifyEffectiveSpecialtyCostChanged();

  public Result LevelUp(Type skillType = null);

  public event PropertyChangedEventHandler PropertyChanged;
}
