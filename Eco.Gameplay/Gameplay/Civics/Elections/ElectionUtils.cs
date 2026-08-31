// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.ElectionUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Misc;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Elections;

public static class ElectionUtils
{
  public static 
  #nullable disable
  string GetElectionName(this CivicAction action);

  public static void RemoveFromDraftElections(CivicAction action);

  public static IEnumerable<Election> ElectionsConcerningActions(params CivicAction[] entries);

  public static IEnumerable<Election> ElectionsConcerningProposables(
    params IProposable[] proposables);

  /// <summary>We make sure to remove all proposables that are related to the specified proposables.</summary>
  public static void RemoveElectionsConcerningProposables(params IProposable[] proposables);

  public static bool DoesElectionConcernsProposable(this Election election, IProposable proposable);

  public static IEnumerable<IProposable> AllProposables(this IEnumerable<Election> elections);

  public static IEnumerable<IProposable> AllProposables(this Election election);

  public static IEnumerable<IProposable> ProposablesBecomingActive(this Election election);

  public static IEnumerable<IProposable> ProposablesBeingReplaced(this Election election);

  public static void GenerateName(Election election);

  [Localized(true, false, "", false)]
  private enum CivicActionCategory
  {
    Expansion,
    Reduction,
    Adjustment,
    Initiative,
    Restructuring,
  }
}
