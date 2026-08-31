// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ConstitutionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Constitutional;
using Eco.Gameplay.Settlements;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
public class ConstitutionManager : 
  Singleton<ConstitutionManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  public static ThreadSafeAction<Constitution> ConstitutionChangedEvent;
  public static ThreadSafeAction<Constitution, Settlement> ConstitutionPassedEvent;

  /// <summary>All the active articles, from both the constitution and any amendments that modify that list.  Will contain invalid articles too.</summary>
  [SyncToView(null, true)]
  public ControllerDictionary<Settlement, List<CivicArticle>> SettlementToCurrentArticles { get; set; }

  public IEnumerable<CivicArticle> CurrentValidArticles(Settlement settlement);

  /// <summary>Set the constitution for a given settlement</summary>
  public void SetConstitution(Constitution constitution, Settlement settlement = null);

  public void UpdateConstitution(Settlement settlement);

  public void Initialize();

  /// <summary>The constitution's effective articles for a settlement: its own articles, plus those added by the given amendments, minus those the amendments remove.</summary>
  public IEnumerable<CivicArticle> EffectiveArticles(
    Settlement settlement,
    IEnumerable<ConstitutionalAmendment> amends);

  public ref int ControllerID { get; }
}
