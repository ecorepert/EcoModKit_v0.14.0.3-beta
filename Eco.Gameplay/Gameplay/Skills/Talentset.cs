// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.Talentset
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Simulation.Agents;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Skills;

[Serialized]
public class Talentset : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public static ThreadSafeAction<Talentset, User> TalentsetChanged;
  public Func<Plant, ItemStack, User, ItemStack> OnPlantHarvest;

  public event PropertyChangedEventHandler PropertyChanged;

  [Serialized]
  [Notify]
  public ControllerList<Type> Talents { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("Talents", true)]
  public IEnumerable<string> TalentStrings { get; }

  /// <summary> Syncs talent names that have level &gt; 1 to the client. Parallel to <see cref="P:Eco.Gameplay.Skills.Talentset.TalentLevelValues" />. </summary>
  [SyncToView(null, true)]
  public IEnumerable<string> TalentLevelNames { get; }

  /// <summary> Syncs talent levels &gt; 1 to the client. Parallel to <see cref="P:Eco.Gameplay.Skills.Talentset.TalentLevelNames" />. </summary>
  [SyncToView(null, true)]
  public IEnumerable<int> TalentLevelValues { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public void Initialize();

  public void SetOwner(User owner);

  public bool HasTalent<T>();

  public bool HasTalent(Type type);

  public bool HasTalent(string name);

  public T GetTalent<T>() where T : Talent;

  public Talent GetTalent(Type t);

  public int GetTalentLevel(Type talentType);

  public void SetTalentLevel(Type talentType, int level);

  /// <summary>Records stars paid toward a talent group (learn or level-up) so unlearn can refund exactly what was paid.</summary>
  public void AddStarsPaid(Type talentGroupType, int stars);

  /// <summary>Removes and returns the total stars paid toward a talent group, or null when nothing was recorded (learns predating payment tracking).</summary>
  public int? TakeStarsPaid(Type talentGroupType);

  public void LearnTalent(Type talentType);

  public void UnLearnTalent(Type talentType);

  public void ResetAllTalents();

  public void ClearTalents();

  public void ClearTalent(Type talentType);
}
