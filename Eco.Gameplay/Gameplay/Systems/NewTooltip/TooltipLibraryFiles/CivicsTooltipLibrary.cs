// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.CivicsTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Civics.Districts;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Immigration;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Components;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class CivicsTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (CivicArticle), "Priority", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 119, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ArticleSpecificity(this 
  #nullable disable
  CivicArticle article);

  [TooltipAffectedBy(typeof (CivicArticle), "AppliesTo", null, null)]
  [TooltipAffectedBy(typeof (CivicArticle), "UserDescription", null, null)]
  [TooltipAffectedBy(typeof (CivicArticle), "ElectionProcess", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (CivicArticle), "Proposers", "OnUserSetChanged", null)]
  [TooltipAffectedBy(typeof (CivicArticle), "Executors", "OnUserSetChanged", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ArticleDescription(this CivicArticle article);

  [TooltipAffectedBy(typeof (Title), true)]
  [TooltipAffectedBy(typeof (ElectedTitle), "EligibleCandidates", "State", typeof (IProposable))]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TitlePropertiesTooltip(this Title title);

  [TooltipAffectedBy(typeof (Title), "SettingsChangedEvent", null, null)]
  [TooltipAffectedBy(typeof (Title), "OccupantString", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 90, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TitleOccupantsTooltip(this Title title);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 500, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TitleDebugTooltip(this Title title, User user);

  [TooltipAffectedBy(typeof (ElectionProcess), true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ElectionProcessProperties(this ElectionProcess process);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TooltipElections(this ElectionProcess electionProcess);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString CanRunTooltip(this ElectedTitle title, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ElectedTitleTermTooltip(this ElectedTitle electedTitle);

  [TooltipAffectedBy(typeof (DistrictMap), "Name", null, null)]
  [TooltipAffectedBy("Description", null, null)]
  [TooltipAffectedBy("Districts", null, null)]
  [TooltipAffectedBy("Districts", "MarkedUpName", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DistrictMapTooltip(this DistrictMap map);

  [TooltipAffectedBy(typeof (District), "ContainingMap", null, null)]
  [TooltipAffectedBy(typeof (District), "ContainingMap", "MarkedUpName", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DistrictTooltip(this District district);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DemographicUser(this Demographic demographic, User user);

  [TooltipAffectedBy(true)]
  [TooltipAffectedBy("Settlement", "Enabled", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString LawTooltip(this Law law);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString LawTriggerTooltip(this Law law);

  [TooltipAffectedBy(typeof (Election), true)]
  [TooltipAffectedBy(typeof (Election), "ElectionStartedEvent", null, null)]
  [TooltipAffectedBy(typeof (Election), "ElectionFinishedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString MainInformationTooltip(this Election election);

  [TooltipAffectedBy(typeof (Election), "Process", "VotersChanged", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 101, TTCat.Default, TTFlags.None, null, new Type[] {}, Flags = TTFlags.ClearCacheForAllUsers)]
  public static LocString ElectionCanVote(this Election election, User user);

  [TooltipAffectedBy(typeof (IProposable), true)]
  [TooltipAffectedBy("Settlement", "MarkedUpName", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TooltipProposable(this IProposable proposable);

  [TooltipAffectedBy(typeof (GamePickerList), "InternalDescription", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString GamePickerListDescription(this GamePickerList pickerList);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 500, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString RegistrarTooltip(this ISpecialRegistrarEntry entry);

  [TooltipAffectedBy(typeof (ImmigrationPolicy), true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ImmigrationTooltip(this ImmigrationPolicy policy);

  [TooltipAffectedBy(typeof (Constitution), "Name", null, null)]
  [TooltipAffectedBy(typeof (Constitution), "UserDescription", null, null)]
  [TooltipAffectedBy(typeof (Constitution), "Articles", null, null)]
  [TooltipAffectedBy(typeof (Constitution), "Articles", "Name", null)]
  [TooltipAffectedBy(typeof (Constitution), "Articles", "UserDescription", null)]
  [TooltipAffectedBy(typeof (Constitution), "Articles", "AppliesTo", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ConstitutionDescription(this Constitution constitution);

  [NewTooltipTitle(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString ContractClauseTooltipTitle(ContractClause clause);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (ContractClause), new Type[] {})]
  public static LocString ContractHelpText(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString CivicActionTooltip(this PerformCivicActionComponent civicAction);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 105, TTCat.Default, TTFlags.None, typeof (CivicAction), new Type[] {})]
  public static LocString CivicActionPlaceTooltip(Type type);

  [TooltipAffectedBy("DualPermissions", "ManagerSet", null)]
  [TooltipAffectedBy(typeof (AppointedTitle), "ManagerSetAliasRenamedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString AppointedTitleDescription(this AppointedTitle title);
}
