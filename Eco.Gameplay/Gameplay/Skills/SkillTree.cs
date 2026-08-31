// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillTree
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Skills;

/// <summary>Helper class to send skill trees to client, skills are organized into trees based on reflection, with skills
/// that have no required skills being root-level tree skills</summary>
public class SkillTree : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public static 
  #nullable disable
  ThreadSafeAction<SkillTree> ResearchProjectChangedEvent;

  [Notify]
  public static ThreadSafeAction<SkillTree> DiscoveredEvent { get; }

  /// <summary>The user who Discovered the Skill.</summary>
  [SyncToView(null, true)]
  public User DiscoveredBy { get; }

  /// <summary>The requirements built from the tier.</summary>
  [SyncToView(null, true)]
  public SkillReqs CachedSkillReqs { get; }

  [SyncToView(null, true)]
  public double TimeDiscovered { get; }

  [SyncToView(null, true)]
  public bool Discovered { get; }

  [SyncToView(null, true)]
  public SkillTree Root { get; }

  [SyncToView(null, true)]
  public SkillTree Specialty { get; }

  [SyncToView(null, true)]
  public SkillTree Parent { get; }

  /// <summary>The item in the global list of items representing the skill</summary>
  [SyncToView(null, true)]
  public Skill StaticSkill { get; }

  /// <summary>The children of the skill tree in profession/speciality basis.</summary>
  [SyncToView(null, true)]
  public SkillTree[] ProfessionChildren { get; }

  /// <summary>The children of this skill based on its SkillBook ingredients. (research basis), The key is the child skill tree and the value is the level of the parent skill at which it can unlock at.</summary>
  [SyncToView(null, true)]
  public Dictionary<SkillTree, int> RequiredSkillLevelsMap { get; }

  [SyncToView(null, true)]
  public bool RequiresScroll { get; }

  /// <summary>Level for professions means 'how many specialties under that profession'. For specialties, means the level of the specialty.</summary>
  [SyncToView(null, true)]
  public List<int> NonAbandonedPlayerCountAtEachLevel { get; set; }

  /// <summary>The map of recipes unlocked at each level.</summary>
  [SyncToView(null, true)]
  public Dictionary<int, List<RecipeFamily>> LevelToRecipeUnlocked { get; set; }

  /// <summary>Specifies the node depth for the research tree.</summary>
  [SyncToView(null, true)]
  public int TreeResearchRank { get; }

  /// <summary>The current active research project.</summary>
  [SyncToView(null, true)]
  public WorkOrder ResearchProject { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public Item SkillScrollItem { get; }

  [SyncToView(null, true)]
  public Item SkillBookItem { get; }

  [SyncToView(null, true)]
  public Item SkillBookTable { get; }

  /// <summary> True if there are recipes available for the skill book. </summary>
  [SyncToView(null, true)]
  public bool IsUsingSkillBook { get; set; }

  [SyncToView(null, true)]
  public IngredientElement[] SkillItemIngredients { get; }

  [SyncToView(null, true)]
  public string SkillScrollMarkedUpName { get; }

  /// <summary>Current active workorders for the skill book that tech this skill.</summary>
  [SyncToView(null, true)]
  public ControllerList<WorkOrder> ResearchWorkOrders { get; set; }

  public bool IsProfession { get; }

  /// <summary>The collection of the skill tree children by its ingredients.</summary>
  public ICollection<SkillTree> IngredientChildren { get; set; }

  public static bool IsDiscovered(Type skillType);

  public IEnumerable<SkillTree> ChildrenRecursive();

  public IEnumerable<SkillTree> ChildrenRecursive(Func<SkillTree, bool> condition);

  public override string ToString();

  public void Initialize();

  public void TryDiscover(double timeLearned, User discoverer);

  public virtual event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public static SkillTree[] AllSkillTrees { get; }

  public static SkillTree[] ProfessionSkillTrees { get; }

  public static SkillTree[] ResearchSkillTrees { get; }

  public static SkillTree RootTreeFromSkill(Type skillType);

  public static SkillTree SpecialtyTreeFromSkill(Type skillType);

  public static SkillTree SkillTreeFromSkill(Type skillType);

  public static int TotalSpecialties { get; }

  public static int TotalProfessions { get; }

  /// <summary>Build the skill trees.</summary>
  public static void BuildSkillTrees();

  public static void InitializeSkillTrees();

  public static void OnWorkOrderUpdate(WorkOrder workOrder);

  /// <summary>Checks for Requires Skill Attribute Skill <see cref="T:System.Type" /></summary>
  private class RequiresSkillAttributeEqualityComparer : IEqualityComparer<RequiresSkillAttribute>
  {
    public bool Equals(RequiresSkillAttribute t1, RequiresSkillAttribute t2);

    public int GetHashCode(RequiresSkillAttribute bx);
  }
}
